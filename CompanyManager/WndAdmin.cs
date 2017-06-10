using CompanySystem;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CompanyManager
{
	public partial class WndAdmin : Form
	{
		public WndAdmin()
		{
			InitializeComponent();

			Text = Master.Instance.WindowTitle;

			LoadDepartments();
			LoadEmployees();
			LoadManagers();
		}

		private void LoadEmployees()
		{
			listEmployees.Items.Clear();

			var users = Master.Instance.Users;
			var selectedDepartment = cbDepartments.SelectedItem as Department;
			if (selectedDepartment != null)
				users = Master.Instance.Users.Where(u => u.Department == selectedDepartment).ToList();

			foreach (var item in users)
			{
				if (item is Employee)
					AddUser(listEmployees, item);
			}
		}

		private void LoadManagers()
		{
			listManagers.Items.Clear();

			var users = Master.Instance.Users;
			var selectedDepartment = cbDepartments.SelectedItem as Department;
			if (selectedDepartment != null)
				users = Master.Instance.Users.Where(u => u.Department == selectedDepartment).ToList();

			foreach (var item in users)
			{
				if (item is Manager)
					AddUser(listManagers, item);
			}
		}

		private void LoadDepartments()
		{
			listDepartments.Items.Clear();
			foreach (var item in Master.Instance.Departments)
			{
				AddDepartment(item);
			}

			// reload filter combo box too

			// remember last selected item
			var selected = (Department)cbDepartments.SelectedItem;
			cbDepartments.Items.Clear();

			cbDepartments.Items.AddRange(Master.Instance.Departments.ToArray());
			if (selected != null)
			{
				foreach (var cbItem in cbDepartments.Items)
				{
					if (((Department)cbItem).Id == selected.Id)
						cbDepartments.SelectedItem = cbItem;
				}
			}
		}

		private void btnEditDepartment_Click(object sender, EventArgs e)
		{
			var selectedItem = listDepartments.SelectedItems[0];
			var selectedDepartment = (Department)selectedItem.Tag;
			var dlgDepartment = new DlgDepartment
			{
				Owner = this,
				StartPosition = FormStartPosition.CenterParent,
				Department = selectedDepartment,
			};

			if (dlgDepartment.ShowDialog() == DialogResult.OK)
			{
				Master.Instance.Departments.Remove(dlgDepartment.Department);
				Master.Instance.Departments.Add(dlgDepartment.Department);

				selectedItem.Tag = dlgDepartment.Department;
				selectedItem.SubItems[0].Text = selectedDepartment.Id.ToString();
				selectedItem.SubItems[1].Text = selectedDepartment.Name;
				selectedItem.SubItems[2].Text = selectedDepartment.Description;

				listDepartments.Refresh();
				LoadEmployees();
				LoadManagers();
			}
		}

		private void btnAddDepartment_Click(object sender, EventArgs e)
		{
			var dlgDepartment = new DlgDepartment
			{
				Owner = this,
				StartPosition = FormStartPosition.CenterParent
			};

			if (dlgDepartment.ShowDialog() == DialogResult.OK)
			{
				AddDepartment(dlgDepartment.Department);
				Master.Instance.Departments.Add(dlgDepartment.Department);
				cbDepartments.Items.Add(dlgDepartment.Department);
				LoadEmployees();
				LoadManagers();
			}
		}

		private void btnDeleteDeaprtment_Click(object sender, EventArgs e)
		{
			var selected = listDepartments.SelectedItems[0];
			if (selected != null)
			{
				listDepartments.Items.Remove(selected);
				Master.Instance.Departments.Remove((Department)selected.Tag);
			}
		}

		private void AddDepartment(Department item)
		{
			var lvItem = new ListViewItem(new string[] {
					item.Id.ToString(),
					item.Name,
					item.Description});

			lvItem.Tag = item;
			listDepartments.Items.Add(lvItem);
		}

		private void AddUser(ListView list, User item)
		{
			var lvItem = new ListViewItem(
				new string[] {
					item.Id.ToString(),
					item.ToString(),
					item.Department.Name
				});

			lvItem.Tag = item;
			list.Items.Add(lvItem);
		}

		private void listDepartments_DoubleClick(object sender, EventArgs e)
		{
			var selected = listDepartments.SelectedItems[0];
			if (selected != null)
			{
				btnEditDepartment_Click(this, e);
			}
		}

		private void listDepartments_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnDeleteDepartment.Enabled = listDepartments.SelectedItems.Count > 0;
			btnEditDepartment.Enabled = listDepartments.SelectedItems.Count > 0;
		}

		private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadEmployees();
			LoadManagers();
		}

		private void btnClearFilter_Click(object sender, EventArgs e)
		{
			cbDepartments.SelectedItem = null;
		}

		private void PromoteEmployee(ListViewItem employeeItem, Manager manager)
		{
			var employee = (Employee)employeeItem.Tag;
			listEmployees.Items.Remove(employeeItem);

			Master.Instance.Users.Remove(employee);
			employee.Department.Employees.Remove(employee);

			Master.Instance.Users.Add(manager);
			manager.Department.Employees.Add(manager);

			AddUser(listManagers, manager);
		}
		
		private void list_DoubleClick(object sender, EventArgs e)
		{
			var list = (ListView)sender;

			if (list.SelectedItems.Count == 0)
				return;

			var selectedItem = list.SelectedItems[0];
			var selectedUser = (User)selectedItem.Tag;
			bool wasUser = selectedUser is User;

			var dlg = new DlgUser
			{
				Text = "Edit user",
				User = selectedUser,
				Owner = this,
				StartPosition = FormStartPosition.CenterParent
			};

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				if (dlg.User is Manager && wasUser)
				{
					PromoteEmployee(selectedItem, (Manager)dlg.User);
				}

				selectedItem.SubItems[0].Text = selectedUser.Department.Id.ToString();
				selectedItem.SubItems[1].Text = selectedUser.ToString();
				selectedItem.SubItems[2].Text = selectedUser.Department.Name;
			}
		}
	}
}
