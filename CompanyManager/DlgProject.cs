using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
	public partial class DlgProject : Form
	{
		public DlgProject()
		{
			InitializeComponent();
		}

		public Project Project { get; set; }

		private void DlgProject_Load(object sender, EventArgs e)
		{
			cbState.Items.AddRange(Enum.GetValues(typeof(ProjectState)).Cast<object>().ToArray());

			if (Project == null)
			{
				txtManager.Text = Master.Instance.CurentUser.Name;
				cbState.SelectedItem = ProjectState.New;
				cbState.Enabled = false;
				Text = "Create new Project";
			}
			else
			{
				Text = "Edit project";
				txtTitle.Text = Project.Title;
				dateStartDate.Value = Project.StartTime;
				dateEndDate.Value = Project.EndTime;
				txtDescription.Text = Project.Description;
				cbState.SelectedItem = Project.State;
				txtCost.Text = Project.Cost.ToString();
				txtManager.Text = Master.Instance.CurentUser.Name;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Manager manager = (Manager)Master.Instance.CurentUser;
			if (Project == null)
			{
				Project = new Project()
				{
					Id = Master.Instance.NextObjectId,
					Title = txtTitle.Text,
					StartTime = dateStartDate.Value,
					EndTime = dateEndDate.Value,
					Description = txtDescription.Text,
					State = ProjectState.New,
					Cost = Convert.ToDecimal(txtCost.Text),
					Manager = manager
				};

				manager.Projects.Add(Project);
			}
			else
			{
				Project.Title = txtTitle.Text;
				Project.StartTime = dateStartDate.Value;
				Project.EndTime = dateEndDate.Value;
				Project.Description = txtDescription.Text;
				Project.State = (ProjectState)cbState.SelectedItem;
				Project.Cost = Convert.ToDecimal(txtCost.Text);
				Project.Manager = manager;
			}
		}
	}
}
