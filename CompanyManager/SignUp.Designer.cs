namespace CompanyManager
{
    partial class SignUp
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxUsernameSignUp = new System.Windows.Forms.TextBox();
            this.textBoxPasswordSignUp = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserNameSignUp = new System.Windows.Forms.Label();
            this.lblPaswwordSignUp = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancelSignUp = new System.Windows.Forms.Button();
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(102, 34);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(102, 62);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxUsernameSignUp
            // 
            this.textBoxUsernameSignUp.Location = new System.Drawing.Point(102, 90);
            this.textBoxUsernameSignUp.Name = "textBoxUsernameSignUp";
            this.textBoxUsernameSignUp.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsernameSignUp.TabIndex = 2;
            // 
            // textBoxPasswordSignUp
            // 
            this.textBoxPasswordSignUp.Location = new System.Drawing.Point(102, 117);
            this.textBoxPasswordSignUp.Name = "textBoxPasswordSignUp";
            this.textBoxPasswordSignUp.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordSignUp.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(42, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(38, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUserNameSignUp
            // 
            this.lblUserNameSignUp.AutoSize = true;
            this.lblUserNameSignUp.Location = new System.Drawing.Point(41, 92);
            this.lblUserNameSignUp.Name = "lblUserNameSignUp";
            this.lblUserNameSignUp.Size = new System.Drawing.Size(55, 13);
            this.lblUserNameSignUp.TabIndex = 1;
            this.lblUserNameSignUp.Text = "Username";
            // 
            // lblPaswwordSignUp
            // 
            this.lblPaswwordSignUp.AutoSize = true;
            this.lblPaswwordSignUp.Location = new System.Drawing.Point(43, 120);
            this.lblPaswwordSignUp.Name = "lblPaswwordSignUp";
            this.lblPaswwordSignUp.Size = new System.Drawing.Size(53, 13);
            this.lblPaswwordSignUp.TabIndex = 1;
            this.lblPaswwordSignUp.Text = "Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSignUp.Location = new System.Drawing.Point(46, 260);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.OnClickRegister);
            // 
            // btnCancelSignUp
            // 
            this.btnCancelSignUp.Location = new System.Drawing.Point(149, 260);
            this.btnCancelSignUp.Name = "btnCancelSignUp";
            this.btnCancelSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSignUp.TabIndex = 5;
            this.btnCancelSignUp.Text = "Cancel";
            this.btnCancelSignUp.UseVisualStyleBackColor = true;
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(102, 145);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDepartments.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 148);
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
            this.rbEmployee.TabIndex = 8;
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
            this.rbManager.TabIndex = 8;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmployee);
            this.groupBox1.Controls.Add(this.rbManager);
            this.groupBox1.Location = new System.Drawing.Point(41, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 80);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User type";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDepartments);
            this.Controls.Add(this.btnCancelSignUp);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblPaswwordSignUp);
            this.Controls.Add(this.lblUserNameSignUp);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.textBoxPasswordSignUp);
            this.Controls.Add(this.textBoxUsernameSignUp);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxUsernameSignUp;
        private System.Windows.Forms.TextBox textBoxPasswordSignUp;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserNameSignUp;
        private System.Windows.Forms.Label lblPaswwordSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancelSignUp;
        private System.Windows.Forms.ComboBox comboBoxDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}