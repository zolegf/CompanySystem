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
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "APS",
            "05.06.2017"}, -1);
			this.btnEditProject = new System.Windows.Forms.Button();
			this.btnDeleteProject = new System.Windows.Forms.Button();
			this.btnAddProject = new System.Windows.Forms.Button();
			this.listProjects = new System.Windows.Forms.ListView();
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			this.btnAddTask = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbProjects = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEditProject
			// 
			this.btnEditProject.Enabled = false;
			this.btnEditProject.Location = new System.Drawing.Point(508, 144);
			this.btnEditProject.Name = "btnEditProject";
			this.btnEditProject.Size = new System.Drawing.Size(87, 23);
			this.btnEditProject.TabIndex = 14;
			this.btnEditProject.Text = "Edit";
			this.btnEditProject.UseVisualStyleBackColor = true;
			this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
			// 
			// btnDeleteProject
			// 
			this.btnDeleteProject.Enabled = false;
			this.btnDeleteProject.Location = new System.Drawing.Point(614, 144);
			this.btnDeleteProject.Name = "btnDeleteProject";
			this.btnDeleteProject.Size = new System.Drawing.Size(87, 23);
			this.btnDeleteProject.TabIndex = 14;
			this.btnDeleteProject.Text = "Delete";
			this.btnDeleteProject.UseVisualStyleBackColor = true;
			this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
			// 
			// btnAddProject
			// 
			this.btnAddProject.Location = new System.Drawing.Point(404, 144);
			this.btnAddProject.Name = "btnAddProject";
			this.btnAddProject.Size = new System.Drawing.Size(87, 23);
			this.btnAddProject.TabIndex = 14;
			this.btnAddProject.Text = "Add";
			this.btnAddProject.UseVisualStyleBackColor = true;
			this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
			// 
			// listProjects
			// 
			this.listProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.StartDate,
            this.EndDate,
            this.State,
            this.columnHeader7,
            this.Description});
			this.listProjects.FullRowSelect = true;
			this.listProjects.HideSelection = false;
			this.listProjects.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
			this.listProjects.Location = new System.Drawing.Point(15, 19);
			this.listProjects.MultiSelect = false;
			this.listProjects.Name = "listProjects";
			this.listProjects.Size = new System.Drawing.Size(686, 119);
			this.listProjects.TabIndex = 15;
			this.listProjects.UseCompatibleStateImageBehavior = false;
			this.listProjects.View = System.Windows.Forms.View.Details;
			this.listProjects.SelectedIndexChanged += new System.EventHandler(this.listProjects_SelectedIndexChanged);
			this.listProjects.DoubleClick += new System.EventHandler(this.listProjects_DoubleClick);
			// 
			// ID
			// 
			this.ID.Text = "ID";
			this.ID.Width = 24;
			// 
			// Title
			// 
			this.Title.Text = "Title";
			this.Title.Width = 114;
			// 
			// StartDate
			// 
			this.StartDate.Text = "Start Time";
			this.StartDate.Width = 81;
			// 
			// EndDate
			// 
			this.EndDate.Text = "End Time";
			this.EndDate.Width = 73;
			// 
			// State
			// 
			this.State.Text = "State";
			this.State.Width = 95;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Cost";
			this.columnHeader7.Width = 69;
			// 
			// Description
			// 
			this.Description.Text = "Description";
			this.Description.Width = 198;
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
			this.listTasks.HideSelection = false;
			this.listTasks.Location = new System.Drawing.Point(15, 58);
			this.listTasks.Name = "listTasks";
			this.listTasks.Size = new System.Drawing.Size(686, 119);
			this.listTasks.TabIndex = 16;
			this.listTasks.UseCompatibleStateImageBehavior = false;
			this.listTasks.View = System.Windows.Forms.View.Details;
			this.listTasks.SelectedIndexChanged += new System.EventHandler(this.listTasks_SelectedIndexChanged);
			this.listTasks.DoubleClick += new System.EventHandler(this.listTasks_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 23;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Title";
			this.columnHeader2.Width = 104;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Start Time";
			this.columnHeader3.Width = 64;
			// 
			// EndTime
			// 
			this.EndTime.Text = "End Time";
			this.EndTime.Width = 66;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Hours";
			this.columnHeader6.Width = 52;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "State";
			this.columnHeader8.Width = 91;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Description";
			this.columnHeader4.Width = 146;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Assigned Employee";
			this.columnHeader5.Width = 110;
			// 
			// btnEditTask
			// 
			this.btnEditTask.Enabled = false;
			this.btnEditTask.Location = new System.Drawing.Point(508, 183);
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
			this.btnDeleteTask.Location = new System.Drawing.Point(614, 183);
			this.btnDeleteTask.Name = "btnDeleteTask";
			this.btnDeleteTask.Size = new System.Drawing.Size(87, 23);
			this.btnDeleteTask.TabIndex = 18;
			this.btnDeleteTask.Text = "Delete";
			this.btnDeleteTask.UseVisualStyleBackColor = true;
			this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
			// 
			// btnAddTask
			// 
			this.btnAddTask.Location = new System.Drawing.Point(404, 182);
			this.btnAddTask.Name = "btnAddTask";
			this.btnAddTask.Size = new System.Drawing.Size(87, 23);
			this.btnAddTask.TabIndex = 18;
			this.btnAddTask.Text = "Add";
			this.btnAddTask.UseVisualStyleBackColor = true;
			this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnEditProject);
			this.groupBox1.Controls.Add(this.btnDeleteProject);
			this.groupBox1.Controls.Add(this.btnAddProject);
			this.groupBox1.Controls.Add(this.listProjects);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(715, 182);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Projects";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnClearFilter);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cbProjects);
			this.groupBox2.Controls.Add(this.listTasks);
			this.groupBox2.Controls.Add(this.btnEditTask);
			this.groupBox2.Controls.Add(this.btnAddTask);
			this.groupBox2.Controls.Add(this.btnDeleteTask);
			this.groupBox2.Location = new System.Drawing.Point(12, 212);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(715, 219);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tasks";
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.Location = new System.Drawing.Point(303, 24);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(87, 21);
			this.btnClearFilter.TabIndex = 21;
			this.btnClearFilter.Text = "Clear fiter";
			this.btnClearFilter.UseVisualStyleBackColor = true;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Project";
			// 
			// cbProjects
			// 
			this.cbProjects.FormattingEnabled = true;
			this.cbProjects.Location = new System.Drawing.Point(94, 24);
			this.cbProjects.Name = "cbProjects";
			this.cbProjects.Size = new System.Drawing.Size(183, 21);
			this.cbProjects.TabIndex = 19;
			// 
			// WndManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 449);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "WndManager";
			this.Text = "ManagerForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnAddProject;
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
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Button btnClearFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbProjects;
	}
}