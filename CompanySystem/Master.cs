using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CompanySystem
{
	[Serializable]
	public sealed class Master
	{
		public const string AppName = "CompanySystem";

		private const string CompanyFile = "c:\\Data\\Data.bin";
		private static Master _master;
		public int LastId { get; set; }
		public List<Department> Departments { get; set; } = new List<Department>();
		public List<Project> Projects { get; set; } = new List<Project>();
		public List<Task> Tasks { get; set; } = new List<Task>();
		public List<User> Users { get; set; } = new List<User>();
		public User CurentUser { get; private set; }
		public string WindowTitle { get; private set; }

		private Master()
		{
			Users.Add(new Admin()
			{
				Id = NextObjectId,
				FirstName = "Admin",
				LastName = "Admin",
				Username = "admin",
				Password = "admin"
			});

			var manager = new Manager()
			{
				Id = NextObjectId,
				FirstName = "Zoran",
				LastName = "Govedar",
				Username = "zoran",
				Password = "zoran",
				DateOfBirth = DateTime.Today.Subtract(TimeSpan.FromDays(33 * 365))
			};

			Users.Add(manager);

			var employee = new Employee()
			{
				Id = NextObjectId,
				FirstName = "Goran",
				LastName = "Boric",
				Username = "goran",
				Password = "goran",
				DateOfBirth = DateTime.Today.Subtract(TimeSpan.FromDays(35 * 365))
		};
			Users.Add(employee);

			var employee2 = new Employee()
			{
				Id = NextObjectId,
				FirstName = "Sima",
				LastName = "Simic",
				Username = "simke",
				Password = "simke",
				DateOfBirth = DateTime.Today.Subtract(TimeSpan.FromDays(25 * 365))
			};
			Users.Add(employee2);

			var project = new Project
			{
				Id = NextObjectId,
				Title = "APS",
				Description = "Sample project for learning purpose.",
				StartTime = DateTime.Today,
				EndTime = DateTime.Today.AddDays(10),
				State = ProjectState.New,
				Manager = manager
			};

			var task = new Task()
			{
				Id = NextObjectId,
				Title = "QA",
				StartTime = DateTime.Now,
				EndTime = DateTime.Now.AddHours(10),
				TaskHours = 10,
				TaskState = TaskState.To_Do,
				Description = "Testing some shit!!",
				Employee = employee,
				Project = project
			};

			Projects.Add(project);
			project.Tasks.Add(task);
			Tasks.Add(task);

			manager.Tasks.Add(task);
			manager.Projects.Add(project);

			Departments.AddRange(new[]
			{
				new Department() { Id = NextObjectId, Name = "Accounting", Description = "Taking care about finance..." },
				new Department() { Id = NextObjectId, Name = "Production", Description = "Taking care about development new products" },
				new Department() { Id = NextObjectId, Name = "Marketing", Description = "Convincig people to buy products..." },
				new Department() { Id = NextObjectId, Name = "Sales", Description = "Seling products..." },
			});

			var accountingDepartment = Departments.Find(d => d.Name.Equals("Accounting"));
			manager.Department = accountingDepartment;
			employee.Department = accountingDepartment;
			employee2.Department = accountingDepartment;

			accountingDepartment.Employees.AddRange(new User[] { employee, employee2 });
		}

		private static Master Load()
		{
			return new Master(); //!! DEBUG !!!!

			//////////////////////////////////////////////////

			if (!File.Exists(CompanyFile))
			{
				return new Master();
			}
			else
			{

				using (var stream = File.Open(CompanyFile, FileMode.Open))
				{
					var formatter = new BinaryFormatter();
					return (Master)formatter.Deserialize(stream);
				}
			}
		}

		public static Master Instance
		{
			get
			{
				if (_master == null)
				{
					_master = Load();
					_master.SaveChanges();
				}

				return _master;
			}
		}

		public User Authenticate(string userName, string password)
		{
			if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
				return null;

			CurentUser = Users.Find(item => item.Username == userName);
			if (CurentUser == null)
				return null;

			if (CurentUser.Password != password)
				return null;

			WindowTitle = $"{AppName}: {CurentUser?.GetType().Name}";

			return CurentUser;
		}

		public void SaveChanges()
		{
			if (!Directory.Exists(Path.GetDirectoryName(CompanyFile)))
				Directory.CreateDirectory(Path.GetDirectoryName(CompanyFile));

			using (FileStream stream = new FileStream(CompanyFile, FileMode.Create))
			{
				var formatter = new BinaryFormatter();
				formatter.Serialize(stream, this);
			}
		}

		public void AddUser(User user)
		{
			Users.Add(user);
		}

		public void PromoteEmployee(Employee employee, Manager manager)
		{
			Users.Remove(employee);
			employee.Department.Employees.Remove(employee);

			Users.Add(manager);
			manager.Department.Employees.Remove(manager);
		}

		public void AddDepartment(Department department)
		{
			Departments.Add(department);
		}

		public void AddTask(Task task)
		{
			task.Project.Manager.Tasks.Add(task);
			task.Employee.Projects.Add(task.Project);
			task.Project.Tasks.Add(task);
			Tasks.Add(task);
		}

		public void AddProject(Project project)
		{
			Projects.Add(project);
			project.Manager.Projects.Add(project);
		}

		public void DeleteProject(Project project)
		{
			project.Manager.Tasks.RemoveAll(t => t.Project.Equals(project));
			project.Manager.Projects.Remove(project);
			foreach (Employee user in Users.Where(u => u is Employee))
			{
				user.Projects.Remove(project);
			}

			Tasks.RemoveAll(t => t.Project.Equals(project));
		}

		public void DeleteTask(Task task)
		{
			task.Project.Manager.Tasks.Remove(task);
			task.Project.Tasks.Remove(task);
			Tasks.Remove(task);
		}

		public void DeleteDepartment(Department department)
		{
			Departments.Remove(department);
		}

		public int NextObjectId
		{
			get { return ++LastId; }
		}
	}
}
