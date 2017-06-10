namespace CompanyManager
{
    partial class DlgProject
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
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dateStartDate = new System.Windows.Forms.DateTimePicker();
			this.dateEndDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.cbState = new System.Windows.Forms.ComboBox();
			this.txtManager = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(126, 19);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(223, 20);
			this.txtTitle.TabIndex = 0;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(126, 97);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(223, 40);
			this.txtDescription.TabIndex = 3;
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point(126, 169);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(133, 20);
			this.txtCost.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Start Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "End Time";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Description";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Cost";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(184, 237);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(274, 237);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// dateStartDate
			// 
			this.dateStartDate.CustomFormat = "dd.MM.yyyy (hh:mm)";
			this.dateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateStartDate.Location = new System.Drawing.Point(126, 45);
			this.dateStartDate.Name = "dateStartDate";
			this.dateStartDate.Size = new System.Drawing.Size(133, 20);
			this.dateStartDate.TabIndex = 1;
			// 
			// dateEndDate
			// 
			this.dateEndDate.CustomFormat = "dd.MM.yyyy (hh:mm)";
			this.dateEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateEndDate.Location = new System.Drawing.Point(126, 71);
			this.dateEndDate.Name = "dateEndDate";
			this.dateEndDate.Size = new System.Drawing.Size(133, 20);
			this.dateEndDate.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "State";
			// 
			// cbState
			// 
			this.cbState.FormattingEnabled = true;
			this.cbState.Location = new System.Drawing.Point(126, 144);
			this.cbState.Name = "cbState";
			this.cbState.Size = new System.Drawing.Size(223, 21);
			this.cbState.TabIndex = 4;
			// 
			// txtManager
			// 
			this.txtManager.Location = new System.Drawing.Point(126, 195);
			this.txtManager.Name = "txtManager";
			this.txtManager.ReadOnly = true;
			this.txtManager.Size = new System.Drawing.Size(223, 20);
			this.txtManager.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 198);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Manager";
			// 
			// DlgProject
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 288);
			this.Controls.Add(this.cbState);
			this.Controls.Add(this.dateEndDate);
			this.Controls.Add(this.dateStartDate);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtManager);
			this.Controls.Add(this.txtCost);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtTitle);
			this.Name = "DlgProject";
			this.Text = "Project";
			this.Load += new System.EventHandler(this.DlgProject_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        protected internal System.Windows.Forms.DateTimePicker dateEndDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbState;
		private System.Windows.Forms.TextBox txtManager;
		private System.Windows.Forms.Label label7;
	}
}