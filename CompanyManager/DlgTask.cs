using System;
using System.Linq;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
	public partial class DlgTask : Form
	{
		public DlgTask()
		{
			InitializeComponent();
		}

		public Task Task { get; set; }

		private void TaskDlg_Load(object sender, EventArgs e)
		{
			Manager user = (Manager)Master.Instance.CurentUser;

			cbEmployees.Items.AddRange(user.Department.Employees.ToArray());
			cbProjects.Items.AddRange(user.Projects.ToArray());

			if (Task == null)
			{
				Text = "Create a new Task";
			}
			else
			{
				Text = "Edit Task";
				txtTaskTitle.Text = Task.Title;
				dateStartTime.Value = Task.StartTime;
				dateEndTime.Value = Task.EndTime;
				textTaskHours.Text = Task.TaskHours.ToString();
				txtTaskDescription.Text = Task.Description;

				cbEmployees.SelectedItem = Task.Employee;
				cbProjects.SelectedItem = Task.Project;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (Task == null)
			{
				Manager user = (Manager)Master.Instance.CurentUser;
				Task = new Task()
				{
					Id = Master.Instance.NextObjectId,
					Title = txtTaskTitle.Text,
					StartTime = dateStartTime.Value,
					EndTime = dateEndTime.Value,
					TaskHours = Convert.ToInt32(textTaskHours.Text),
					Description = txtTaskDescription.Text,
					Employee = (Employee)cbEmployees.SelectedItem,
					Project = (Project)cbProjects.SelectedItem,				
				};

				user.Tasks.Add(Task);
				Task.Employee.Projects.Add(Task.Project);
				Master.Instance.Tasks.Add(Task);
				Task.Project.Tasks.Add(Task);
			}
			else
			{
				Task.Title = txtTaskTitle.Text;
				Task.StartTime = dateStartTime.Value;
				Task.EndTime = dateEndTime.Value;
				Task.TaskHours = Convert.ToInt32(textTaskHours.Text);
				Task.Description = txtTaskDescription.Text;

				Task.Employee = (Employee)cbEmployees.SelectedItem;
				Task.Project = (Project)cbProjects.SelectedItem;
			}
		}
	}
}
