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
    public partial class DlgSignIn : Form
    {
        public DlgSignIn()
        {
            InitializeComponent();
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnClickSignUp(object sender, EventArgs e)
        {
            var SignUp = new DlgSignUp();
            SignUp.ShowDialog();

            
        }

        private void onClickLogIn(object sender, EventArgs e)
        {

            var Main = new Main();

            User user = Master.Instance.Users.Find(item => item.Username == textBoxUsername.Text);
            //bool containsManager = Master.Instance.Managers.Any(item => item.Password.Equals(textBoxPassword.Text));
            //bool contansEmployee = Master.Instance.Employees.Any(item => item.Password.Equals(textBoxPassword.Text));
            if (user == null)
            {
                MessageBox.Show("User sa unetim kredencijalima ne postoji u evidenciji!");
            }
            else if (textBoxUsername.Text.Equals("admin") && textBoxPassword.Text.Equals("admin"))
            {
                var AdminForm = new WndAdmin();
                AdminForm.ShowDialog();
            }
            else if(user is Manager)
            {
                Master.Instance.curentUser = user;
                var ManagerForm = new WndManager();
                ManagerForm.ShowDialog();
            }
            
            

        }
    }
}
