using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		private void LoadEmployees(ListBox list, IEnumerable<User> users)
		{
			list.Items.Clear();

			foreach (var item in users)
			{
				if (item is Employee)
					list.Items.Add(item);
			}
		}

		private void onAddToDepartmentClick(object sender, EventArgs e)
		{
			lbDepartmentEmployees.Items.Add(lbAllEmployees.SelectedItem);
		}

		private void onRemoveFromDepartmentClick(object sender, EventArgs e)
		{
			lbDepartmentEmployees.Items.Remove(lbDepartmentEmployees.SelectedItem);
		}

		private void OnUsersIndexChanged(object sender, EventArgs e)
		{
			btnAddToDepartment.Enabled = lbAllEmployees.SelectedItem != null;
		}

		private void lbDepartmentEmployees_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnRemoveFromDepartment.Enabled = lbDepartmentEmployees.SelectedItem != null;
		}

		private void onClickOK(object sender, EventArgs e)
		{
			if (Department == null)
			{
				var newDepartment = new Department()
				{
					Id = Master.Instance.NextObjectId,
					Name = txtDepartmentName.Text,
					Description = txtDepartmentDescription.Text,
				};

				foreach (var item in lbDepartmentEmployees.Items)
				{
					var user = (User)item;
					user.Department?.Employees.Remove(user);
					newDepartment.Employees.Add(user);
					user.Department = newDepartment;
				}

				Master.Instance.Departments.Add(newDepartment);
				Department = newDepartment;
			}
			else
			{
				Department.Name = txtDepartmentName.Text;
				Department.Description = txtDepartmentDescription.Text;

				foreach (var employee in Department.Employees)
				{
					employee.Department = null;
				}

				Department.Employees.Clear();

				foreach (var item in lbDepartmentEmployees.Items)
				{
					var user = (User)item;
					Department.Employees.Add(user);
					user.Department = Department;
				}
			}

			DialogResult = DialogResult.OK;
		}

		private void DlgDepartment_Load(object sender, EventArgs e)
		{
			if (Department != null)
			{
				txtDepartmentName.Text = Department.Name;
				txtDepartmentDescription.Text = Department.Description;
				LoadEmployees(lbDepartmentEmployees, Department.Employees);
			}

			LoadEmployees(lbAllEmployees, Master.Instance.Users);
		}
	}
}
