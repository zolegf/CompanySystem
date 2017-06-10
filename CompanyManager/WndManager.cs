using System;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
	public partial class WndManager : Form
	{
		public WndManager()
		{
			InitializeComponent();

			LoadProjects((Manager)Master.Instance.CurentUser);
			Text = Master.Instance.WindowTitle;
		}

		private void LoadProjects(Manager manager)
		{
			listProjects.Items.Clear();

			foreach (var item in manager.Projects)
			{
				AddProject(item);
			}
		}

		private void btnAddProject_Click(object sender, EventArgs e)
		{
			var projectDlg = new DlgProject()
			{
				Owner = this,
				StartPosition = FormStartPosition.CenterParent
			};

			if (projectDlg.ShowDialog() == DialogResult.OK)
			{
				Master.Instance.Projects.Add(projectDlg.Project);
				AddProject(projectDlg.Project);
			}
		}

		void AddProject(Project item)
		{
			var listItem = new ListViewItem(new string[]
				{
					item.Id.ToString(),
					item.Title.ToString(),
					item.StartTime.ToShortDateString(),
					item.EndTime.ToShortDateString(),
					item.State.ToString(),
					item.Cost.ToString(),
					item.Description
				});

			listItem.Tag = item;
			listProjects.Items.Add(listItem);
		}

		private void LoadTaskList(Project project)
		{
			listTasks.Items.Clear();

			foreach (var item in project.Tasks)
			{
				var listItem = new ListViewItem(new string[]
				{
					item.Id.ToString(),
					item.Title.ToString(),
					item.StartTime.ToShortTimeString(),
					item.EndTime.ToShortTimeString(),
					item.TaskHours.ToString(),
					item.TaskState.ToString(),
					item.Description,
					item.Employee.FirstName

				});

				listItem.Tag = item;
				listTasks.Items.Add(listItem);
			}
		}

		private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnEditProject.Enabled = listProjects.SelectedItems.Count > 0;
			btnDeleteProject.Enabled = listProjects.SelectedItems.Count > 0;

			var selectedItem = listProjects.SelectedItems[0];
			if (selectedItem != null)
			{
				var project = (Project)selectedItem.Tag;
				LoadTaskList(project);
			}
		}

		private void btnAddTask_Click(object sender, EventArgs e)
		{
			var taskDlg = new DlgTask() { Owner = this, StartPosition = FormStartPosition.CenterParent };
			if (taskDlg.ShowDialog() == DialogResult.OK)
			{
				var task = (Task)taskDlg.Tag;

				var listItem = new ListViewItem(new string[]
				{
					task.Id.ToString(),
					task.Title,
					task.StartTime.ToString(),
					task.EndTime.ToString(),
					task.TaskHours.ToString(),
					task.Description
				});

				listTasks.Items.Add(listItem);
			}
		}

		private void btnDeleteProject_Click(object sender, EventArgs e)
		{
			Manager user = (Manager)Master.Instance.CurentUser;
			var selectedItem = listProjects.SelectedItems[0];
			if (selectedItem != null)
			{
				var project = (Project)selectedItem.Tag;
				LoadTaskList(project);
				user.Projects.Remove(project);
			}
			Master.Instance.SaveChanges();
		}

		private void btnEditProject_Click(object sender, EventArgs e)
		{
			var selectedItem = listProjects.SelectedItems[0];
			var project = (Project)selectedItem.Tag;
			var projectDlg = new DlgProject()
			{
				Owner = this,
				StartPosition = FormStartPosition.CenterParent,
				Project = project
			};

			if (projectDlg.ShowDialog() == DialogResult.OK)
			{
				selectedItem.SubItems[1].Text = project.Title;
				selectedItem.SubItems[2].Text = project.StartTime.ToShortDateString();
				selectedItem.SubItems[3].Text = project.EndTime.ToShortDateString();
				selectedItem.SubItems[4].Text = project.State.ToString();
				selectedItem.SubItems[5].Text = project.Cost.ToString();
				selectedItem.SubItems[6].Text = project.Description;
			}
		}

		private void btnEditTask_Click(object sender, EventArgs e)
		{
			var taskDlg = new DlgTask() { Owner = this, StartPosition = FormStartPosition.CenterParent, Task = (Task)listTasks.SelectedItems[0].Tag };
			if (taskDlg.ShowDialog() == DialogResult.OK)
			{
				listTasks.Refresh();
			}
		}

		private void listProjects_DoubleClick(object sender, EventArgs e)
		{
			if (listProjects.SelectedItems.Count > 0)
				btnEditProject_Click(this, e);
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
