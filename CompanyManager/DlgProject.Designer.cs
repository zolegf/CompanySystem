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
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupState = new System.Windows.Forms.GroupBox();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.radioInProgress = new System.Windows.Forms.RadioButton();
            this.radioFinished = new System.Windows.Forms.RadioButton();
            this.groupState.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(65, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(65, 90);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(223, 40);
            this.txtDescription.TabIndex = 0;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(65, 136);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(100, 20);
            this.txtManager.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Manager";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(188, 255);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.onClickOK);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.onClickCancel);
            // 
            // dateStartDate
            // 
            this.dateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartDate.Location = new System.Drawing.Point(63, 38);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(102, 20);
            this.dateStartDate.TabIndex = 4;
            // 
            // dateEndDate
            // 
            this.dateEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndDate.Location = new System.Drawing.Point(63, 64);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(102, 20);
            this.dateEndDate.TabIndex = 4;
            // 
            // groupState
            // 
            this.groupState.Controls.Add(this.radioFinished);
            this.groupState.Controls.Add(this.radioInProgress);
            this.groupState.Controls.Add(this.radioNew);
            this.groupState.Location = new System.Drawing.Point(65, 162);
            this.groupState.Name = "groupState";
            this.groupState.Size = new System.Drawing.Size(112, 90);
            this.groupState.TabIndex = 5;
            this.groupState.TabStop = false;
            this.groupState.Text = "State";
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.Checked = true;
            this.radioNew.Location = new System.Drawing.Point(18, 16);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(47, 17);
            this.radioNew.TabIndex = 0;
            this.radioNew.TabStop = true;
            this.radioNew.Text = "New";
            this.radioNew.UseVisualStyleBackColor = true;
            // 
            // radioInProgress
            // 
            this.radioInProgress.AutoSize = true;
            this.radioInProgress.Location = new System.Drawing.Point(18, 39);
            this.radioInProgress.Name = "radioInProgress";
            this.radioInProgress.Size = new System.Drawing.Size(75, 17);
            this.radioInProgress.TabIndex = 0;
            this.radioInProgress.Text = "InProgress";
            this.radioInProgress.UseVisualStyleBackColor = true;
            // 
            // radioFinished
            // 
            this.radioFinished.AutoSize = true;
            this.radioFinished.Location = new System.Drawing.Point(18, 62);
            this.radioFinished.Name = "radioFinished";
            this.radioFinished.Size = new System.Drawing.Size(64, 17);
            this.radioFinished.TabIndex = 0;
            this.radioFinished.Text = "Finished";
            this.radioFinished.UseVisualStyleBackColor = true;
            // 
            // ProjectDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 286);
            this.Controls.Add(this.groupState);
            this.Controls.Add(this.dateEndDate);
            this.Controls.Add(this.dateStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Name = "ProjectDlg";
            this.Text = "ProjectDlg";
            this.groupState.ResumeLayout(false);
            this.groupState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        protected internal System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.GroupBox groupState;
        private System.Windows.Forms.RadioButton radioFinished;
        private System.Windows.Forms.RadioButton radioInProgress;
        private System.Windows.Forms.RadioButton radioNew;
    }
}