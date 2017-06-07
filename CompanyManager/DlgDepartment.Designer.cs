namespace CompanyManager
{
    partial class DlgDepartment
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
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listEmployees = new System.Windows.Forms.ListBox();
            this.listDepartmentEmployees = new System.Windows.Forms.ListBox();
            this.btnAddToDepartment = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveFromDepartment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(121, 27);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(224, 20);
            this.txtDepartmentName.TabIndex = 0;
            // 
            // txtDepartmentDescription
            // 
            this.txtDepartmentDescription.Location = new System.Drawing.Point(12, 84);
            this.txtDepartmentDescription.Multiline = true;
            this.txtDepartmentDescription.Name = "txtDepartmentDescription";
            this.txtDepartmentDescription.Size = new System.Drawing.Size(333, 40);
            this.txtDepartmentDescription.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department description";
            // 
            // listEmployees
            // 
            this.listEmployees.FormattingEnabled = true;
            this.listEmployees.Location = new System.Drawing.Point(16, 156);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(138, 108);
            this.listEmployees.TabIndex = 2;
            this.listEmployees.SelectedIndexChanged += new System.EventHandler(this.OnUsersIndexChanged);
            // 
            // listDepartmentEmployees
            // 
            this.listDepartmentEmployees.FormattingEnabled = true;
            this.listDepartmentEmployees.Location = new System.Drawing.Point(197, 156);
            this.listDepartmentEmployees.Name = "listDepartmentEmployees";
            this.listDepartmentEmployees.Size = new System.Drawing.Size(148, 108);
            this.listDepartmentEmployees.TabIndex = 2;
            // 
            // btnAddToDepartment
            // 
            this.btnAddToDepartment.Location = new System.Drawing.Point(160, 156);
            this.btnAddToDepartment.Name = "btnAddToDepartment";
            this.btnAddToDepartment.Size = new System.Drawing.Size(31, 23);
            this.btnAddToDepartment.TabIndex = 3;
            this.btnAddToDepartment.Text = "=>";
            this.btnAddToDepartment.UseVisualStyleBackColor = true;
            this.btnAddToDepartment.Click += new System.EventHandler(this.onAddToDepartmentClick);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(176, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.onClickOK);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.onClickCancel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "All Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department Users";
            // 
            // btnRemoveFromDepartment
            // 
            this.btnRemoveFromDepartment.Location = new System.Drawing.Point(160, 185);
            this.btnRemoveFromDepartment.Name = "btnRemoveFromDepartment";
            this.btnRemoveFromDepartment.Size = new System.Drawing.Size(31, 23);
            this.btnRemoveFromDepartment.TabIndex = 3;
            this.btnRemoveFromDepartment.Text = "<=";
            this.btnRemoveFromDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveFromDepartment.Click += new System.EventHandler(this.onAddToDepartmentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onClickOK);
            // 
            // DlgDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRemoveFromDepartment);
            this.Controls.Add(this.btnAddToDepartment);
            this.Controls.Add(this.listDepartmentEmployees);
            this.Controls.Add(this.listEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartmentDescription);
            this.Controls.Add(this.txtDepartmentName);
            this.Name = "DlgDepartment";
            this.Text = "DlgDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listEmployees;
        private System.Windows.Forms.ListBox listDepartmentEmployees;
        private System.Windows.Forms.Button btnAddToDepartment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveFromDepartment;
        private System.Windows.Forms.Button button1;
    }
}