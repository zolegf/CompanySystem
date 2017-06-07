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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            

            var form1 = new SignIn();
            if (form1.ShowDialog() == DialogResult.Cancel)
            {
                Close();
                return;
            }

            //lblCurrentUser.Text = Master.Instance.curentUser.Username;

        }
        
    }
}
