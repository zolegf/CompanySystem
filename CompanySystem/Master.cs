using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				Password = "zoran"
			};
			Users.Add(manager);

			var employee = new Employee()
			{
				Id = NextObjectId,
				FirstName = "Goran",
				LastName = "Boric",
				Username = "goran",
				Password = "goran"
			};
			Users.Add(employee);

			var employee2 = new Employee()
			{
				Id = NextObjectId,
				FirstName = "Sima",
				LastName = "Simic",
				Username = "simke",
				Password = "simke"
			};
			Users.Add(employee2);

			var project = new Project
			{
				Id = NextObjectId,
				Title = "APS",
				Description = "Sample project for learning purpose.",
				StartDate = DateTime.Today,
				EndDate = DateTime.Today.AddDays(10),
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
				Employee = employee
			};

			Projects.Add(project);
			project.Tasks.Add(task);

			manager.Projects.Add(project);

			Departments.AddRange(new[]
			{
				new Department() { Id = NextObjectId, Name = "Accounting", Description = "Taking care about finance..." },
				new Department() { Id = NextObjectId, Name = "Production", Description = "Taking care about development new products" },
				new Department() { Id = NextObjectId, Name = "Marketing", Description = "Convincig people to buy products..." },
				new Department() { Id = NextObjectId, Name = "Sales", Description = "Seling products..." },
			});

			manager.Department = Departments.Find(d => d.Name.Equals("Accounting"));
			employee.Department = Departments.Find(d => d.Name.Equals("Accounting"));
			employee2.Department = Departments.Find(d => d.Name.Equals("Accounting"));
		}

		private static Master Load()
		{
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
			var user = Users.Find(item => item.Username == userName);
			CurentUser = user;
			WindowTitle = $"{AppName}: {CurentUser.GetType().Name}";

			return user != null && user.Password == password ? user : null;
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

		public void CreateProject()
		{
			//TODO
		}

		public void EditProject()
		{
			//TODO
		}

		public void DeleteProject()
		{
			//TODO
		}

		public void CreateTask()
		{
			//TODO
		}


		public List<Task> GetTasks()
		{
			//TODO
			return null;
		}

		public void SetProjectState()
		{
			//TODO

		}

		public int NextObjectId
		{
			get { return ++LastId; }
		}
	}
}
