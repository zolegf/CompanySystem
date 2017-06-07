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
            LoadDepartmentList();
        }

        private void LoadDepartmentList()
        {
            foreach (var item in Master.Instance.Users)
            {
                if (item is Admin)
                    continue;

                listEmployees.Items.Add(item);
            }
        }

        private void onAddToDepartmentClick(object sender, EventArgs e)
        {
            listDepartmentEmployees.Items.Add(listEmployees.SelectedItem);
        }

        private void OnUsersIndexChanged(object sender, EventArgs e)
        {
            btnAddToDepartment.Enabled = listEmployees.SelectedItem != null;
        }

        private void onClickOK(object sender, EventArgs e)
        {
            var newDepartment = new Department()
            {
                Id = Master.Instance.NextObjectId,
                Name = txtDepartmentName.Text,
                Description = txtDepartmentDescription.Text,
        };

            foreach (var item in listDepartmentEmployees.Items)
            {
                var user = (User)item;
                user.Department.Employees.Remove(user);
                newDepartment.Employees.Add(user);
                user.Department = newDepartment;
            }

            Master.Instance.Departments.Add(newDepartment);
            Master.Instance.SaveChanges();

            DialogResult = DialogResult.OK;
            

        }

        private void onClickCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
