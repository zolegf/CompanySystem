using System;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
    public partial class TaskDlg : Form
    {
        public TaskDlg()
        {
            InitializeComponent();
        }

        public Task Task { get; set; }

        private void onClickOK(object sender, EventArgs e)
        {
            if (Task == null)
            {
                Manager user = (Manager)Master.Instance.curentUser;
                var task = new Task()
                {
                    Id = Master.Instance.NextObjectId,
                    Title = txtTaskTitle.Text,
                    StartTime = dateStartTime.Value,
                    EndTime = dateEndTime.Value,
                    TaskHours = Convert.ToInt32(textTaskHours.Text),
                    Description = txtTaskDescription.Text,
                    Employee = (Employee)comboEmployees.SelectedItem,
                    Project = (Project)comboProjects.SelectedItem
                };

                task.Project.Tasks.Add(task);

                Master.Instance.Tasks.Add(task);
                Master.Instance.SaveChanges();

                Task = task;
            }
            else
            {
                Task.Title = txtTaskTitle.Text;
                Task.StartTime = dateStartTime.Value;
                Task.EndTime = dateEndTime.Value;
                Task.TaskHours = Convert.ToInt32(textTaskHours.Text);
                Task.Description = txtTaskDescription.Text;
                
                //Task.Employee = (Employee)comboEmployees.SelectedItem;
                //Task.Project = (Project)comboProjects.SelectedItem;
            }

            DialogResult = DialogResult.OK;
        }

        private void onClickCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TaskDlg_Load(object sender, EventArgs e)
        {
            if (Task == null)
            {
                Manager user = (Manager)Master.Instance.curentUser;
                foreach (var item in Master.Instance.Users)
                {
                    if (item is Manager || item is Admin || item.Department != user.Department)
                        continue;

                    comboEmployees.Items.Add(item);
                }
                foreach (var item in user.Projects)
                {
                    comboProjects.Items.Add(item);
                }
            }
            else
            {
                txtTaskTitle.Text = Task.Title;
                    //StartTime = dateStartTime.Value,
                    //EndTime = dateEndTime.Value,
                    //TaskHours = Convert.ToInt32(textTaskHours.Text),
                    //Description = txtTaskDescription.Text,
                    //Employee = (Employee)comboEmployees.SelectedItem,
                    //Project = (Project)comboProjects.SelectedItem
            }
        }
    }
}
