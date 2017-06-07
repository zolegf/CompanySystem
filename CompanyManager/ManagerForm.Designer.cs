namespace CompanyManager
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "APS",
            "05.06.2017"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnAddNewProject = new System.Windows.Forms.Button();
            this.listProjects = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project List";
            // 
            // btnEditProject
            // 
            this.btnEditProject.Location = new System.Drawing.Point(271, 133);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(87, 23);
            this.btnEditProject.TabIndex = 14;
            this.btnEditProject.Text = "Edit";
            this.btnEditProject.UseVisualStyleBackColor = true;
            this.btnEditProject.Click += new System.EventHandler(this.onClickEdit);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(364, 133);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteProject.TabIndex = 14;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.onClickDelete);
            // 
            // btnAddNewProject
            // 
            this.btnAddNewProject.Location = new System.Drawing.Point(457, 133);
            this.btnAddNewProject.Name = "btnAddNewProject";
            this.btnAddNewProject.Size = new System.Drawing.Size(87, 23);
            this.btnAddNewProject.TabIndex = 14;
            this.btnAddNewProject.Text = "Add New";
            this.btnAddNewProject.UseVisualStyleBackColor = true;
            this.btnAddNewProject.Click += new System.EventHandler(this.onClickAddNewProject);
            // 
            // listProjects
            // 
            this.listProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.StartDate,
            this.EndDate,
            this.State,
            this.Description});
            this.listProjects.FullRowSelect = true;
            this.listProjects.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listProjects.Location = new System.Drawing.Point(14, 25);
            this.listProjects.MultiSelect = false;
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(530, 102);
            this.listProjects.TabIndex = 15;
            this.listProjects.UseCompatibleStateImageBehavior = false;
            this.listProjects.View = System.Windows.Forms.View.Details;
            this.listProjects.SelectedIndexChanged += new System.EventHandler(this.listProjects_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // StartDate
            // 
            this.StartDate.Text = "Start Date";
            this.StartDate.Width = 78;
            // 
            // EndDate
            // 
            this.EndDate.Text = "End Date";
            // 
            // State
            // 
            this.State.Text = "State";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 120;
            // 
            // listTasks
            // 
            this.listTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.EndTime,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader4,
            this.columnHeader5});
            this.listTasks.Location = new System.Drawing.Point(14, 167);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(530, 97);
            this.listTasks.TabIndex = 16;
            this.listTasks.UseCompatibleStateImageBehavior = false;
            this.listTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start Time";
            // 
            // EndTime
            // 
            this.EndTime.Text = "End Time";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Task Hours";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Task State";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Assigned Employee";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Task List";
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(271, 271);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(87, 23);
            this.btnEditTask.TabIndex = 18;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(364, 271);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteTask.TabIndex = 18;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Location = new System.Drawing.Point(457, 270);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(87, 23);
            this.btnAddNewTask.TabIndex = 18;
            this.btnAddNewTask.Text = "Add New";
            this.btnAddNewTask.UseVisualStyleBackColor = true;
            this.btnAddNewTask.Click += new System.EventHandler(this.onClickAddNewTask);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 408);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.btnAddNewProject);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.label1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnAddNewProject;
        private System.Windows.Forms.ListView listProjects;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ListView listTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}