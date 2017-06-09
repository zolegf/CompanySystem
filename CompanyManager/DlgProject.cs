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
    public partial class DlgProject : Form
    {
        public DlgProject()
        {
            InitializeComponent();
            string managerName = Master.Instance.CurentUser.FirstName + " " + Master.Instance.CurentUser.LastName;
            txtManager.Text = managerName;
        }

        private void onClickOK(object sender, EventArgs e)
        {
            Manager user = (Manager)Master.Instance.CurentUser;
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

            // dodaj projekat u master listu i u Tag
            // Tag = 
            Master.Instance.SaveChanges();
            DialogResult = DialogResult.OK;
            
            
        }

        private void onClickCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
