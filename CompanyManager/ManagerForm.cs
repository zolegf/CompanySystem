﻿using System;
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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            
            LoadProjects((Manager)Master.Instance.curentUser);
        }

        private void LoadProjects(Manager manager)
        {
            
            listProjects.Items.Clear();

            foreach (var item in manager.Projects)
            {
                var listItem = new ListViewItem(new string[]
                {
                    item.Id.ToString(),
                    item.Title.ToString(),
                    item.StartDate.ToShortDateString(),
                    item.EndDate.ToShortDateString(),
                    item.State.ToString(),
                    item.Description
                });

                listItem.Tag = item;
                listProjects.Items.Add(listItem);
            }
        }

        private void onClickAddNewProject(object sender, EventArgs e)
        {
            var projectDlg = new ProjectDlg() { Owner = this, StartPosition = FormStartPosition.CenterParent };
            projectDlg.ShowDialog();

        }

        private void LoadTaskList(Project project)
        {
            listTasks.Items.Clear();

            foreach (var item in project.Tasks)
            {
                var listItem = new ListViewItem(new string[]
                {
                    item.Id.ToString(),
                    item.Title.ToString(),
                    item.StartTime.ToShortTimeString(),
                    item.EndTime.ToShortTimeString(),
                    item.TaskHours.ToString(),
                    item.TaskState.ToString(),
                    item.Description,
                    item.Employee.FirstName

                });

                listTasks.Items.Add(listItem);
            }
        }
        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listProjects.SelectedItems[0];
            if (selectedItem != null)
            {
                var project = (Project)selectedItem.Tag;
                LoadTaskList(project);
            }
        }
        private void onClickAddNewTask(object sender, EventArgs e)
        {
            var taskDlg = new TaskDlg() { Owner = this, StartPosition = FormStartPosition.CenterParent };
            taskDlg.ShowDialog();
        }
        private void onClickDelete(object sender, EventArgs e)
        {
            Manager user = (Manager)Master.Instance.curentUser;
            var selectedItem = listProjects.SelectedItems[0];
            if (selectedItem != null)
            {
                var project = (Project)selectedItem.Tag;
                LoadTaskList(project);
                user.Projects.Remove(project);
            }
            Master.Instance.SaveChanges();
        }
        private void onClickEdit(object sender, EventArgs e)
        {
            var selectedItem = listProjects.SelectedItems[0];
            var project = (Project)selectedItem.Tag;
            var projectDlg = new ProjectDlg() { Owner = this, StartPosition = FormStartPosition.CenterParent };
            projectDlg.ShowDialog();

            

        }
    }
}
