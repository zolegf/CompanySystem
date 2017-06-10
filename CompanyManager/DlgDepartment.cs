using System;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
	public partial class DlgDepartment : Form
	{
		public DlgDepartment()
		{
			InitializeComponent();
		}

		public Department Department { get; set; }

		private void onClickOK(object sender, EventArgs e)
		{
			if (Department == null)
			{
				Department = new Department()
				{
					Id = Master.Instance.NextObjectId,
					Name = txtDepartmentName.Text,
					Description = txtDepartmentDescription.Text,
				};
			}
			else
			{
				Department.Name = txtDepartmentName.Text;
				Department.Description = txtDepartmentDescription.Text;
			}
		}

		private void DlgDepartment_Load(object sender, EventArgs e)
		{
			if (Department != null)
			{
				txtDepartmentName.Text = Department.Name;
				txtDepartmentDescription.Text = Department.Description;
			}
		}
	}
}
