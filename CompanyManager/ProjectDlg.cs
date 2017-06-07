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
    public partial class ProjectDlg : Form
    {
        public ProjectDlg()
        {
            InitializeComponent();
            string managerName = Master.Instance.curentUser.FirstName + " " + Master.Instance.curentUser.LastName;
            txtManager.Text = managerName;
        }

        private void onClickOK(object sender, EventArgs e)
        {
            Manager user = (Manager)Master.Instance.curentUser;
            var project = new Project()
            {
                Id = Master.Instance.NextObjectId,
                Title = txtTitle.Text,
                StartDate = dateStartDate.Value,
                EndDate = dateEndDate.Value,
                Description = txtDescription.Text,
                State = ProjectState.New,
                Manager = user
            };
            user.Projects.Add(project);
            Master.Instance.SaveChanges();
            DialogResult = DialogResult.OK;
            
            
        }

        private void onClickCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
