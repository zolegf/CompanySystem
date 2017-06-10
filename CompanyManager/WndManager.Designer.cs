namespace CompanyManager
{
    partial class WndManager
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
			this.btnEditTask = new System.Windows.Forms.Button();
			this.btnDeleteTask = new System.Windows.Forms.Button();
			this.btnAddNewTask = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEditProject
			// 
			this.btnEditProject.Enabled = false;
			this.btnEditProject.Location = new System.Drawing.Point(363, 127);
			this.btnEditProject.Name = "btnEditProject";
			this.btnEditProject.Size = new System.Drawing.Size(87, 23);
			this.btnEditProject.TabIndex = 14;
			this.btnEditProject.Text = "Edit";
			this.btnEditProject.UseVisualStyleBackColor = true;
			this.btnEditProject.Click += new System.EventHandler(this.onClickEdit);
			// 
			// btnDeleteProject
			// 
			this.btnDeleteProject.Enabled = false;
			this.btnDeleteProject.Location = new System.Drawing.Point(469, 127);
			this.btnDeleteProject.Name = "btnDeleteProject";
			this.btnDeleteProject.Size = new System.Drawing.Size(87, 23);
			this.btnDeleteProject.TabIndex = 14;
			this.btnDeleteProject.Text = "Delete";
			this.btnDeleteProject.UseVisualStyleBackColor = true;
			this.btnDeleteProject.Click += new System.EventHandler(this.onClickDelete);
			// 
			// btnAddNewProject
			// 
			this.btnAddNewProject.Location = new System.Drawing.Point(573, 127);
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
			this.listProjects.Location = new System.Drawing.Point(15, 19);
			this.listProjects.MultiSelect = false;
			this.listProjects.Name = "listProjects";
			this.listProjects.Size = new System.Drawing.Size(645, 102);
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
			this.listTasks.FullRowSelect = true;
			this.listTasks.Location = new System.Drawing.Point(15, 19);
			this.listTasks.Name = "listTasks";
			this.listTasks.Size = new System.Drawing.Size(645, 97);
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
			this.columnHeader8.Text = "State";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Description";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 120;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Assigned Employee";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 150;
			// 
			// btnEditTask
			// 
			this.btnEditTask.Enabled = false;
			this.btnEditTask.Location = new System.Drawing.Point(363, 123);
			this.btnEditTask.Name = "btnEditTask";
			this.btnEditTask.Size = new System.Drawing.Size(87, 23);
			this.btnEditTask.TabIndex = 18;
			this.btnEditTask.Text = "Edit";
			this.btnEditTask.UseVisualStyleBackColor = true;
			this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
			// 
			// btnDeleteTask
			// 
			this.btnDeleteTask.Enabled = false;
			this.btnDeleteTask.Location = new System.Drawing.Point(469, 123);
			this.btnDeleteTask.Name = "btnDeleteTask";
			this.btnDeleteTask.Size = new System.Drawing.Size(87, 23);
			this.btnDeleteTask.TabIndex = 18;
			this.btnDeleteTask.Text = "Delete";
			this.btnDeleteTask.UseVisualStyleBackColor = true;
			// 
			// btnAddNewTask
			// 
			this.btnAddNewTask.Location = new System.Drawing.Point(573, 122);
			this.btnAddNewTask.Name = "btnAddNewTask";
			this.btnAddNewTask.Size = new System.Drawing.Size(87, 23);
			this.btnAddNewTask.TabIndex = 18;
			this.btnAddNewTask.Text = "Add New";
			this.btnAddNewTask.UseVisualStyleBackColor = true;
			this.btnAddNewTask.Click += new System.EventHandler(this.onClickAddNewTask);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnEditProject);
			this.groupBox1.Controls.Add(this.btnDeleteProject);
			this.groupBox1.Controls.Add(this.btnAddNewProject);
			this.groupBox1.Controls.Add(this.listProjects);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(677, 162);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Projects";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listTasks);
			this.groupBox2.Controls.Add(this.btnEditTask);
			this.groupBox2.Controls.Add(this.btnAddNewTask);
			this.groupBox2.Controls.Add(this.btnDeleteTask);
			this.groupBox2.Location = new System.Drawing.Point(12, 200);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(677, 156);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tasks";
			// 
			// WndManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 463);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "WndManager";
			this.Text = "ManagerForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}