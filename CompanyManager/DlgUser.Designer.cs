namespace CompanyManager
{
    partial class DlgUser
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
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblUserNameSignUp = new System.Windows.Forms.Label();
			this.lblPaswwordSignUp = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancelSignUp = new System.Windows.Forms.Button();
			this.cbDepartments = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rbEmployee = new System.Windows.Forms.RadioButton();
			this.rbManager = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbGender = new System.Windows.Forms.ComboBox();
			this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(147, 75);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(131, 20);
			this.txtFirstName.TabIndex = 2;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(147, 104);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(131, 20);
			this.txtLastName.TabIndex = 3;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(148, 17);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(131, 20);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(148, 46);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(131, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(58, 78);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(54, 13);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "FirstName";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(58, 107);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(58, 13);
			this.lblLastName.TabIndex = 1;
			this.lblLastName.Text = "Last Name";
			// 
			// lblUserNameSignUp
			// 
			this.lblUserNameSignUp.AutoSize = true;
			this.lblUserNameSignUp.Location = new System.Drawing.Point(58, 20);
			this.lblUserNameSignUp.Name = "lblUserNameSignUp";
			this.lblUserNameSignUp.Size = new System.Drawing.Size(55, 13);
			this.lblUserNameSignUp.TabIndex = 1;
			this.lblUserNameSignUp.Text = "Username";
			// 
			// lblPaswwordSignUp
			// 
			this.lblPaswwordSignUp.AutoSize = true;
			this.lblPaswwordSignUp.Location = new System.Drawing.Point(58, 49);
			this.lblPaswwordSignUp.Name = "lblPaswwordSignUp";
			this.lblPaswwordSignUp.Size = new System.Drawing.Size(53, 13);
			this.lblPaswwordSignUp.TabIndex = 1;
			this.lblPaswwordSignUp.Text = "Password";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(114, 310);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 7;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancelSignUp
			// 
			this.btnCancelSignUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelSignUp.Location = new System.Drawing.Point(203, 310);
			this.btnCancelSignUp.Name = "btnCancelSignUp";
			this.btnCancelSignUp.Size = new System.Drawing.Size(75, 23);
			this.btnCancelSignUp.TabIndex = 8;
			this.btnCancelSignUp.Text = "Cancel";
			this.btnCancelSignUp.UseVisualStyleBackColor = true;
			// 
			// cbDepartments
			// 
			this.cbDepartments.FormattingEnabled = true;
			this.cbDepartments.Location = new System.Drawing.Point(147, 192);
			this.cbDepartments.Name = "cbDepartments";
			this.cbDepartments.Size = new System.Drawing.Size(131, 21);
			this.cbDepartments.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Department";
			// 
			// rbEmployee
			// 
			this.rbEmployee.AutoSize = true;
			this.rbEmployee.Checked = true;
			this.rbEmployee.Location = new System.Drawing.Point(61, 19);
			this.rbEmployee.Name = "rbEmployee";
			this.rbEmployee.Size = new System.Drawing.Size(71, 17);
			this.rbEmployee.TabIndex = 0;
			this.rbEmployee.TabStop = true;
			this.rbEmployee.Text = "Employee\r\n";
			this.rbEmployee.UseVisualStyleBackColor = true;
			// 
			// rbManager
			// 
			this.rbManager.AutoSize = true;
			this.rbManager.Location = new System.Drawing.Point(61, 42);
			this.rbManager.Name = "rbManager";
			this.rbManager.Size = new System.Drawing.Size(67, 17);
			this.rbManager.TabIndex = 1;
			this.rbManager.Text = "Manager";
			this.rbManager.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbEmployee);
			this.groupBox1.Controls.Add(this.rbManager);
			this.groupBox1.Location = new System.Drawing.Point(61, 224);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(217, 80);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Date of Birth";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Gender";
			// 
			// cbGender
			// 
			this.cbGender.FormattingEnabled = true;
			this.cbGender.Location = new System.Drawing.Point(147, 162);
			this.cbGender.Name = "cbGender";
			this.cbGender.Size = new System.Drawing.Size(131, 21);
			this.cbGender.TabIndex = 5;
			// 
			// dtDateOfBirth
			// 
			this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDateOfBirth.Location = new System.Drawing.Point(147, 133);
			this.dtDateOfBirth.Name = "dtDateOfBirth";
			this.dtDateOfBirth.Size = new System.Drawing.Size(131, 20);
			this.dtDateOfBirth.TabIndex = 4;
			// 
			// DlgUser
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 350);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbGender);
			this.Controls.Add(this.cbDepartments);
			this.Controls.Add(this.btnCancelSignUp);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblPaswwordSignUp);
			this.Controls.Add(this.lblUserNameSignUp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.dtDateOfBirth);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimizeBox = false;
			this.Name = "DlgUser";
			this.Text = "SignUp";
			this.Load += new System.EventHandler(this.DlgUser_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserNameSignUp;
        private System.Windows.Forms.Label lblPaswwordSignUp;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelSignUp;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbGender;
		private System.Windows.Forms.DateTimePicker dtDateOfBirth;
	}
}