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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadUsers();

        }

        private void LoadUsers()
        {
            listUsers.Items.Clear();
            foreach (var item in Master.Instance.Users)
            {
                if (item is Admin)
                    continue;

                listUsers.Items.Add(item);
            }
        }

        private void LoadDepartments()
        {
            listDepartments.Items.Clear();
            foreach (var item in Master.Instance.Departments)
            {
                listDepartments.Items.Add(item);
            }

        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = ((User)listUsers.SelectedItem).FirstName;
            txtLastName.Text = ((User)listUsers.SelectedItem).LastName;
            txtUsername.Text = ((User)listUsers.SelectedItem).Username;
            txtPassword.Text = ((User)listUsers.SelectedItem).Password;
            txtDepartment.Text = ((User)listUsers.SelectedItem).Department.Name;
        }

        private void onSaveChanges(object sender, EventArgs e)
        {
            ((User)listUsers.SelectedItem).FirstName = txtName.Text;
            ((User)listUsers.SelectedItem).LastName = txtLastName.Text;
            ((User)listUsers.SelectedItem).Username = txtUsername.Text;
            ((User)listUsers.SelectedItem).Password = txtPassword.Text;
            ((User)listUsers.SelectedItem).Department.Name = txtDepartment.Text;

            Master.Instance.SaveChanges();
        }

        private void onDeleteUser(object sender, EventArgs e)
        {
            
            Master.Instance.Users.Remove((User)listUsers.SelectedItem);
            
            Master.Instance.SaveChanges();
        }

        private void onSelectedItem(object sender, EventArgs e)
        {
            txtBoxDepartmentDescription.Text = ((Department)listDepartments.SelectedItem).Description;
        }

        private void onClick(object sender, EventArgs e)
        {
            var dlgDepartment = new DlgDepartment();
            if (dlgDepartment.ShowDialog() == DialogResult.OK)
            {
                // osvezi listu
                this.LoadDepartments();
            }
        }
    }
}
