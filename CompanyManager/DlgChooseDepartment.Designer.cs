namespace CompanyManager
{
	partial class DlgChooseDepartment
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
			this.lbDepartments = new System.Windows.Forms.ListBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbDepartments
			// 
			this.lbDepartments.FormattingEnabled = true;
			this.lbDepartments.Location = new System.Drawing.Point(12, 12);
			this.lbDepartments.Name = "lbDepartments";
			this.lbDepartments.Size = new System.Drawing.Size(260, 121);
			this.lbDepartments.TabIndex = 0;
			this.lbDepartments.SelectedIndexChanged += new System.EventHandler(this.lbDepartments_SelectedIndexChanged);
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Enabled = false;
			this.btnOk.Location = new System.Drawing.Point(106, 150);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(198, 150);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// DlgChooseDepartment
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 184);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lbDepartments);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DlgChooseDepartment";
			this.Text = "Assign to department";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbDepartments;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button button2;
	}
}