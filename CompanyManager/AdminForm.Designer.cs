namespace CompanyManager
{
    partial class AdminForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPromoteEmployee = new System.Windows.Forms.Button();
            this.listDepartments = new System.Windows.Forms.ListBox();
            this.txtBoxDepartmentDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxAddNewDepartment = new System.Windows.Forms.TextBox();
            this.btnAddNewDepartment = new System.Windows.Forms.Button();
            this.btnEditDeaprtment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.onSaveChanges);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 196);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 222);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(84, 248);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(165, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(84, 274);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(84, 302);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(165, 20);
            this.txtDepartment.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(192, 328);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(57, 23);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Delete user";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.onDeleteUser);
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(31, 33);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(107, 147);
            this.listUsers.TabIndex = 2;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Department";
            // 
            // btnPromoteEmployee
            // 
            this.btnPromoteEmployee.Location = new System.Drawing.Point(117, 357);
            this.btnPromoteEmployee.Name = "btnPromoteEmployee";
            this.btnPromoteEmployee.Size = new System.Drawing.Size(92, 46);
            this.btnPromoteEmployee.TabIndex = 4;
            this.btnPromoteEmployee.Text = "Promote Employee";
            this.btnPromoteEmployee.UseVisualStyleBackColor = true;
            // 
            // listDepartments
            // 
            this.listDepartments.FormattingEnabled = true;
            this.listDepartments.Location = new System.Drawing.Point(145, 33);
            this.listDepartments.Name = "listDepartments";
            this.listDepartments.Size = new System.Drawing.Size(104, 147);
            this.listDepartments.TabIndex = 2;
            this.listDepartments.SelectedIndexChanged += new System.EventHandler(this.onSelectedItem);
            // 
            // txtBoxDepartmentDescription
            // 
            this.txtBoxDepartmentDescription.Location = new System.Drawing.Point(255, 53);
            this.txtBoxDepartmentDescription.Multiline = true;
            this.txtBoxDepartmentDescription.Name = "txtBoxDepartmentDescription";
            this.txtBoxDepartmentDescription.Size = new System.Drawing.Size(258, 46);
            this.txtBoxDepartmentDescription.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Department description";
            // 
            // txtBoxAddNewDepartment
            // 
            this.txtBoxAddNewDepartment.Location = new System.Drawing.Point(343, 105);
            this.txtBoxAddNewDepartment.Name = "txtBoxAddNewDepartment";
            this.txtBoxAddNewDepartment.Size = new System.Drawing.Size(170, 20);
            this.txtBoxAddNewDepartment.TabIndex = 7;
            // 
            // btnAddNewDepartment
            // 
            this.btnAddNewDepartment.Location = new System.Drawing.Point(394, 134);
            this.btnAddNewDepartment.Name = "btnAddNewDepartment";
            this.btnAddNewDepartment.Size = new System.Drawing.Size(119, 23);
            this.btnAddNewDepartment.TabIndex = 8;
            this.btnAddNewDepartment.Text = "Add new Department";
            this.btnAddNewDepartment.UseVisualStyleBackColor = true;
            this.btnAddNewDepartment.Click += new System.EventHandler(this.onClick);
            // 
            // btnEditDeaprtment
            // 
            this.btnEditDeaprtment.Location = new System.Drawing.Point(255, 134);
            this.btnEditDeaprtment.Name = "btnEditDeaprtment";
            this.btnEditDeaprtment.Size = new System.Drawing.Size(119, 23);
            this.btnEditDeaprtment.TabIndex = 10;
            this.btnEditDeaprtment.Text = "Edit Department";
            this.btnEditDeaprtment.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 413);
            this.Controls.Add(this.btnEditDeaprtment);
            this.Controls.Add(this.btnAddNewDepartment);
            this.Controls.Add(this.txtBoxAddNewDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDepartmentDescription);
            this.Controls.Add(this.btnPromoteEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDepartments);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPromoteEmployee;
        private System.Windows.Forms.ListBox listDepartments;
        private System.Windows.Forms.TextBox txtBoxDepartmentDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAddNewDepartment;
        private System.Windows.Forms.Button btnAddNewDepartment;
        private System.Windows.Forms.Button btnEditDeaprtment;
    }
}