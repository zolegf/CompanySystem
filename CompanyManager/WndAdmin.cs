using CompanySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		}

		//private void LoadUsers()
		//{
		//    listUsers.Items.Clear();
		//    foreach (var item in Master.Instance.Users)
		//    {
		//        if (item is Admin)
		//            continue;

		//        listUsers.Items.Add(item);
		//    }
		//}

		private void LoadDepartments()
		{
			listDepartments.Items.Clear();
			foreach (var item in Master.Instance.Departments)
			{
				AddDepartment(item);
			}
		}

		private void btnEditDeaprtment_Click(object sender, EventArgs e)
		{
			var dlgDepartment = new DlgDepartment
			{
				Owner = this,
				StartPosition = FormStartPosition.CenterParent,
				Department = listDepartments.SelectedItems[0]?.Tag as Department,
			};			

			if (dlgDepartment.ShowDialog() == DialogResult.OK)
			{
				Master.Instance.Departments.Remove(dlgDepartment.Department);
				Master.Instance.Departments.Add(dlgDepartment.Department);
				LoadDepartments();
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

		private void listDepartments_DoubleClick(object sender, EventArgs e)
		{
			var selected = listDepartments.SelectedItems[0];
			if (selected != null)
			{
				btnEditDeaprtment_Click(this, e);
			}
		}
	}
}
