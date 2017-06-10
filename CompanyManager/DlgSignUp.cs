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
    public partial class DlgSignUp : Form
    {
        public DlgSignUp()
        {
            InitializeComponent();

            comboBoxDepartments.Items.AddRange(Master.Instance.Departments.ToArray());
        }

        private void OnClickRegister(object sender, EventArgs e)
        {
            User user;
            var department = (Department)comboBoxDepartments.SelectedItem;
            if (rbManager.Checked)
            {

                user = new Manager()
                {
                    Id = Master.Instance.NextObjectId,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Username = textBoxUsernameSignUp.Text,
                    Password = textBoxPasswordSignUp.Text,
                    Department = department,
                };
            }
            else // user je employee
            {
                user = new Employee()
                {
                    Id = Master.Instance.NextObjectId,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Username = textBoxUsernameSignUp.Text,
                    Password = textBoxPasswordSignUp.Text,
                    Department = department,
                };
                

            }

            department.Employees.Add(user);
            Master.Instance.AddUser(user);
            Master.Instance.SaveChanges();
            
            DialogResult = DialogResult.OK; 
        }
    }
}
