using System;
using System.Linq;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
    public partial class DlgUser : Form
    {
        public DlgUser()
        {
            InitializeComponent();

            cbDepartments.Items.AddRange(Master.Instance.Departments.ToArray());
			cbGender.Items.AddRange(Enum.GetValues(typeof(Gender)).Cast<object>().ToArray());
        }

		public User User { get; set; }

		private void DlgUser_Load(object sender, EventArgs e)
		{
			if (User != null)
			{
				txtUsername.Enabled = false;
				txtPassword.Enabled = false;

				txtFirstName.Text = User.FirstName;
				txtLastName.Text = User.LastName;
				txtUsername.Text = User.Username;
				txtPassword.Text = User.Password;

				dtDateOfBirth.Value = User.DateOfBirth;
				cbGender.SelectedItem = User.Gender;
				rbEmployee.Checked = User is Employee;
				rbManager.Checked = User is Manager;

				cbDepartments.SelectedItem = User.Department;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
        {
			// TODO: Validacija inputa

			if (User == null)
			{
				var department = (Department)cbDepartments.SelectedItem;
				if (rbManager.Checked)
				{

					User = new Manager()
					{
						Id = Master.Instance.NextObjectId,
						FirstName = txtFirstName.Text,
						LastName = txtLastName.Text,
						Username = txtUsername.Text,
						Password = txtPassword.Text,
						Department = department,
					};
				}
				else // user je employee
				{
					User = new Employee()
					{
						Id = Master.Instance.NextObjectId,
						FirstName = txtFirstName.Text,
						LastName = txtLastName.Text,
						Username = txtUsername.Text,
						Password = txtPassword.Text,
						Department = department,
					};
				}
			}
			else
			{
				User.FirstName = txtFirstName.Text;
				User.LastName = txtLastName.Text;
				User.Username = txtUsername.Text;
				User.Password = txtPassword.Text;
				User.DateOfBirth = dtDateOfBirth.Value;
				User.Department = (Department)cbDepartments.SelectedItem;
				User.Gender = (Gender)cbGender.SelectedItem;

				if (User is Employee && rbManager.Checked)
				{
					var manager = new Manager
					{
						FirstName = User.FirstName,
						LastName = User.LastName,
						DateOfBirth = User.DateOfBirth,
						Gender = User.Gender,
						Username = User.Username,
						Password = User.Password,
						Department = User.Department
					};

					User = manager;
				}
			}
        }
	}
}
