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

			LoadProjects((Manager)Master.Instance.curentUser);
		}

		private void LoadProjects(Manager manager)
		{

			listProjects.Items.Clear();

			foreach (var item in manager.Projects)
			{
				var listItem = new ListViewItem(new string[]
				{
					item.Id.ToString(),
					item.Title.ToString(),
					item.StartDate.ToShortDateString(),
					item.EndDate.ToShortDateString(),
					item.State.ToString(),
					item.Description
				});

				listItem.Tag = item;
				listProjects.Items.Add(listItem);
			}
		}

		private void onClickAddNewProject(object sender, EventArgs e)
		{
			var projectDlg = new DlgProject() { Owner = this, StartPosition = FormStartPosition.CenterParent };
			projectDlg.ShowDialog();

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
			var selectedItem = listProjects.SelectedItems[0];
			if (selectedItem != null)
			{
				var project = (Project)selectedItem.Tag;
				LoadTaskList(project);
			}
		}

		private void onClickAddNewTask(object sender, EventArgs e)
		{
			var taskDlg = new DlgTaskDlg() { Owner = this, StartPosition = FormStartPosition.CenterParent };
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

		private void onClickDelete(object sender, EventArgs e)
		{
			Manager user = (Manager)Master.Instance.curentUser;
			var selectedItem = listProjects.SelectedItems[0];
			if (selectedItem != null)
			{
				var project = (Project)selectedItem.Tag;
				LoadTaskList(project);
				user.Projects.Remove(project);
			}
			Master.Instance.SaveChanges();
		}

		private void onClickEdit(object sender, EventArgs e)
		{
			var selectedItem = listProjects.SelectedItems[0];
			var project = (Project)selectedItem.Tag;
			var projectDlg = new DlgProject() { Owner = this, StartPosition = FormStartPosition.CenterParent };
			projectDlg.ShowDialog();



		}

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            var taskDlg = new DlgTaskDlg() { Owner = this, StartPosition = FormStartPosition.CenterParent, Task = (Task)listTasks.SelectedItems[0].Tag };
            if (taskDlg.ShowDialog() == DialogResult.OK)
            {
                listTasks.Refresh();
            }
        }
    }
}
