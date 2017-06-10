namespace CompanyManager
{
    partial class DlgTaskDlg
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
			this.txtTaskTitle = new System.Windows.Forms.TextBox();
			this.txtTaskDescription = new System.Windows.Forms.TextBox();
			this.dateStartTime = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboProjects = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.comboEmployees = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textTaskHours = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateEndTime = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// txtTaskTitle
			// 
			this.txtTaskTitle.Location = new System.Drawing.Point(157, 22);
			this.txtTaskTitle.Name = "txtTaskTitle";
			this.txtTaskTitle.Size = new System.Drawing.Size(204, 20);
			this.txtTaskTitle.TabIndex = 0;
			// 
			// txtTaskDescription
			// 
			this.txtTaskDescription.Location = new System.Drawing.Point(157, 48);
			this.txtTaskDescription.Multiline = true;
			this.txtTaskDescription.Name = "txtTaskDescription";
			this.txtTaskDescription.Size = new System.Drawing.Size(204, 40);
			this.txtTaskDescription.TabIndex = 0;
			// 
			// dateStartTime
			// 
			this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateStartTime.Location = new System.Drawing.Point(157, 94);
			this.dateStartTime.Name = "dateStartTime";
			this.dateStartTime.Size = new System.Drawing.Size(100, 20);
			this.dateStartTime.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Start Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Description";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Assigned Employee";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Projects";
			// 
			// comboProjects
			// 
			this.comboProjects.FormattingEnabled = true;
			this.comboProjects.Location = new System.Drawing.Point(157, 210);
			this.comboProjects.Name = "comboProjects";
			this.comboProjects.Size = new System.Drawing.Size(204, 21);
			this.comboProjects.TabIndex = 3;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(192, 250);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.onClickOK);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(286, 250);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.onClickCancel);
			// 
			// comboEmployees
			// 
			this.comboEmployees.FormattingEnabled = true;
			this.comboEmployees.Location = new System.Drawing.Point(157, 183);
			this.comboEmployees.Name = "comboEmployees";
			this.comboEmployees.Size = new System.Drawing.Size(204, 21);
			this.comboEmployees.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 126);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "End Time";
			// 
			// textTaskHours
			// 
			this.textTaskHours.Location = new System.Drawing.Point(157, 146);
			this.textTaskHours.Name = "textTaskHours";
			this.textTaskHours.Size = new System.Drawing.Size(100, 20);
			this.textTaskHours.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 149);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Task Hours";
			// 
			// dateEndTime
			// 
			this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateEndTime.Location = new System.Drawing.Point(157, 120);
			this.dateEndTime.Name = "dateEndTime";
			this.dateEndTime.Size = new System.Drawing.Size(100, 20);
			this.dateEndTime.TabIndex = 1;
			// 
			// DlgTaskDlg
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 288);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textTaskHours);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.comboEmployees);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.comboProjects);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateEndTime);
			this.Controls.Add(this.dateStartTime);
			this.Controls.Add(this.txtTaskDescription);
			this.Controls.Add(this.txtTaskTitle);
			this.Name = "DlgTaskDlg";
			this.Text = "TaskDlg";
			this.Load += new System.EventHandler(this.TaskDlg_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.DateTimePicker dateStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboProjects;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboEmployees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTaskHours;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateEndTime;
	}
}