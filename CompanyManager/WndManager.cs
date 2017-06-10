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
			LoadTaskList();
			Text = Master.Instance.WindowTitle;
		}

		private void LoadProjects(Manager manager)
		{
			listProjects.Items.Clear();
			cbProjects.Items.Clear();

			foreach (var item in manager.Projects)
			{
				cbProjects.Items.Add(item);
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
				AddProject(projectDlg.Project);
				cbProjects.Items.Add(projectDlg.Project);

				LoadTaskList();
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

		void AddTask(Task item)
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
					item.Employee.Name
				});

			listItem.Tag = item;
			listTasks.Items.Add(listItem);
		}

		private void LoadTaskList()
		{
			listTasks.Items.Clear();

			if (cbProjects.SelectedItem != null)
			{
				foreach (var item in ((Project)cbProjects.SelectedItem).Tasks)
				{
					AddTask(item);
				}
			}
			else
			{
				foreach (var item in ((Manager)Master.Instance.CurentUser).Tasks)
				{
					AddTask(item);
				}
			}
		}

		private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnEditProject.Enabled = listProjects.SelectedItems.Count > 0;
			btnDeleteProject.Enabled = listProjects.SelectedItems.Count > 0;

			var selectedItem = listProjects.SelectedItems.Count > 0 ? 
				listProjects.SelectedItems[0] : 
				null;

			if (selectedItem != null)
			{
				var project = (Project)selectedItem.Tag;
				cbProjects.SelectedItem = project;
			}

			LoadTaskList();
		}

		private void btnAddTask_Click(object sender, EventArgs e)
		{
			var taskDlg = new DlgTask()
			{
				Owner = this,
				StartPosition = FormStartPosition.CenterParent
			};

			if (taskDlg.ShowDialog() == DialogResult.OK)
			{
				AddTask(taskDlg.Task);
			}
		}

		private void btnDeleteProject_Click(object sender, EventArgs e)
		{
			Manager user = (Manager)Master.Instance.CurentUser;
			var selectedItem = listProjects.SelectedItems[0];
			if (selectedItem != null)
			{
				var project = (Project)selectedItem.Tag;
				listProjects.Items.Remove(selectedItem);
				if (cbProjects.SelectedItem != null && cbProjects.SelectedItem.Equals(project))
					cbProjects.Text = string.Empty;

				cbProjects.Items.Remove(project);
				Master.Instance.Tasks.RemoveAll(t => t.Project.Equals(project));
				user.Tasks.RemoveAll(t => t.Project.Equals(project));
				user.Projects.Remove(project);

				LoadTaskList();
			}
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
			var selectedItem = listTasks.SelectedItems[0];
			var task = (Task)selectedItem.Tag;

			var taskDlg = new DlgTask()
			{
				Owner = this,
				StartPosition = FormStartPosition.CenterParent,
				Task = task
			};
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

		private void listTasks_DoubleClick(object sender, EventArgs e)
		{
			if (listTasks.SelectedItems.Count > 0)
				btnEditTask_Click(this, e);
		}

		private void btnClearFilter_Click(object sender, EventArgs e)
		{
			cbProjects.SelectedItem = null;
			LoadTaskList();
		}

		private void listTasks_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnEditTask.Enabled = listTasks.SelectedItems.Count > 0;
			btnDeleteTask.Enabled = listTasks.SelectedItems.Count > 0;
		}

		private void btnDeleteTask_Click(object sender, EventArgs e)
		{
			var selectedItem = listTasks.SelectedItems[0];
			var task = (Task)selectedItem.Tag;
			listTasks.Items.Remove(selectedItem);

			var user = (Manager)Master.Instance.CurentUser;
			user.Tasks.Remove(task);
			task.Project.Tasks.Remove(task);
			Master.Instance.Tasks.Remove(task);
		}
	}
}
