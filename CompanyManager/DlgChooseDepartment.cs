using System.Data;
using System.Linq;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
	public partial class DlgChooseDepartment : Form
	{
		public DlgChooseDepartment(Employee employee)
		{
			InitializeComponent();

			Text = $"Assign {employee} to Department";
			lbDepartments.Items.AddRange(Master.Instance.Departments.ToArray());
		}

		public Department Department { get; private set; }

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			Department = (Department)lbDepartments.SelectedItem;
		}

		private void lbDepartments_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			btnOk.Enabled = lbDepartments.SelectedItem != null;
		}
	}
}
