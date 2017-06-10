namespace CompanyManager
{
    partial class WndAdmin
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
			this.btnAddDepartment = new System.Windows.Forms.Button();
			this.btnEditDepartment = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listDepartments = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnDeleteDepartment = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listManagers = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listEmployees = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbDepartments = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAddDepartment
			// 
			this.btnAddDepartment.Location = new System.Drawing.Point(165, 122);
			this.btnAddDepartment.Name = "btnAddDepartment";
			this.btnAddDepartment.Size = new System.Drawing.Size(119, 23);
			this.btnAddDepartment.TabIndex = 8;
			this.btnAddDepartment.Text = "Add";
			this.btnAddDepartment.UseVisualStyleBackColor = true;
			this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
			// 
			// btnEditDepartment
			// 
			this.btnEditDepartment.Enabled = false;
			this.btnEditDepartment.Location = new System.Drawing.Point(305, 122);
			this.btnEditDepartment.Name = "btnEditDepartment";
			this.btnEditDepartment.Size = new System.Drawing.Size(119, 23);
			this.btnEditDepartment.TabIndex = 10;
			this.btnEditDepartment.Text = "Edit";
			this.btnEditDepartment.UseVisualStyleBackColor = true;
			this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(607, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As...";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			// 
			// listDepartments
			// 
			this.listDepartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.description});
			this.listDepartments.FullRowSelect = true;
			this.listDepartments.HideSelection = false;
			this.listDepartments.Location = new System.Drawing.Point(16, 19);
			this.listDepartments.MultiSelect = false;
			this.listDepartments.Name = "listDepartments";
			this.listDepartments.Size = new System.Drawing.Size(548, 97);
			this.listDepartments.TabIndex = 12;
			this.listDepartments.UseCompatibleStateImageBehavior = false;
			this.listDepartments.View = System.Windows.Forms.View.Details;
			this.listDepartments.SelectedIndexChanged += new System.EventHandler(this.listDepartments_SelectedIndexChanged);
			this.listDepartments.DoubleClick += new System.EventHandler(this.listDepartments_DoubleClick);
			// 
			// id
			// 
			this.id.Text = "Id";
			this.id.Width = 30;
			// 
			// name
			// 
			this.name.Text = "Name";
			this.name.Width = 120;
			// 
			// description
			// 
			this.description.Text = "Description";
			this.description.Width = 360;
			// 
			// btnDeleteDepartment
			// 
			this.btnDeleteDepartment.Enabled = false;
			this.btnDeleteDepartment.Location = new System.Drawing.Point(445, 122);
			this.btnDeleteDepartment.Name = "btnDeleteDepartment";
			this.btnDeleteDepartment.Size = new System.Drawing.Size(119, 23);
			this.btnDeleteDepartment.TabIndex = 10;
			this.btnDeleteDepartment.Text = "Delete";
			this.btnDeleteDepartment.UseVisualStyleBackColor = true;
			this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listDepartments);
			this.groupBox1.Controls.Add(this.btnAddDepartment);
			this.groupBox1.Controls.Add(this.btnEditDepartment);
			this.groupBox1.Controls.Add(this.btnDeleteDepartment);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(582, 153);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Departments";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listManagers);
			this.groupBox2.Controls.Add(this.listEmployees);
			this.groupBox2.Controls.Add(this.btnClearFilter);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cbDepartments);
			this.groupBox2.Location = new System.Drawing.Point(12, 207);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(582, 252);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Employees";
			// 
			// listManagers
			// 
			this.listManagers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8});
			this.listManagers.FullRowSelect = true;
			this.listManagers.HideSelection = false;
			this.listManagers.Location = new System.Drawing.Point(305, 92);
			this.listManagers.Name = "listManagers";
			this.listManagers.Size = new System.Drawing.Size(261, 133);
			this.listManagers.TabIndex = 4;
			this.listManagers.UseCompatibleStateImageBehavior = false;
			this.listManagers.View = System.Windows.Forms.View.Details;
			this.listManagers.DoubleClick += new System.EventHandler(this.list_DoubleClick);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Id";
			this.columnHeader4.Width = 25;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Name";
			this.columnHeader5.Width = 98;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Department";
			this.columnHeader8.Width = 107;
			// 
			// listEmployees
			// 
			this.listEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7});
			this.listEmployees.FullRowSelect = true;
			this.listEmployees.HideSelection = false;
			this.listEmployees.Location = new System.Drawing.Point(19, 92);
			this.listEmployees.Name = "listEmployees";
			this.listEmployees.Size = new System.Drawing.Size(265, 133);
			this.listEmployees.TabIndex = 4;
			this.listEmployees.UseCompatibleStateImageBehavior = false;
			this.listEmployees.View = System.Windows.Forms.View.Details;
			this.listEmployees.DoubleClick += new System.EventHandler(this.list_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			this.columnHeader1.Width = 25;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 92;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Department";
			this.columnHeader7.Width = 120;
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.Location = new System.Drawing.Point(305, 27);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(90, 21);
			this.btnClearFilter.TabIndex = 3;
			this.btnClearFilter.Text = "Clear filter";
			this.btnClearFilter.UseVisualStyleBackColor = true;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(302, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Managers";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Employees";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Department";
			// 
			// cbDepartments
			// 
			this.cbDepartments.FormattingEnabled = true;
			this.cbDepartments.Location = new System.Drawing.Point(95, 27);
			this.cbDepartments.Name = "cbDepartments";
			this.cbDepartments.Size = new System.Drawing.Size(189, 21);
			this.cbDepartments.TabIndex = 1;
			this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
			// 
			// WndAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 471);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "WndAdmin";
			this.Text = "Administrator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ListView listDepartments;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader description;
		private System.Windows.Forms.Button btnDeleteDepartment;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbDepartments;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listEmployees;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listManagers;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Button btnClearFilter;
	}
}