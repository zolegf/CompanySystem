using System;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
	public partial class DlgSignIn : Form
	{
		public DlgSignIn()
		{
			InitializeComponent();
		}

		private void onClickLogIn(object sender, EventArgs e)
		{
			User user = Master.Instance.Authenticate(txtUsername.Text, txtPassword.Text);
			if (user == null)
			{
				MessageBox.Show("User sa unetim kredencijalima ne postoji u evidenciji!");
				return;
			}

			Hide();

			if (user is Admin)
			{
				new WndAdmin
				{
					Owner = this,
					StartPosition = FormStartPosition.CenterParent
				}.ShowDialog();
			}
			else if (user is Manager)
			{
				new WndManager
				{
					Owner = this,
					StartPosition = FormStartPosition.CenterParent
				}.ShowDialog();
			}
			else
			{
				new WndEmployee
				{
					Owner = this,
					StartPosition = FormStartPosition.CenterParent
				}.ShowDialog();
			}

			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void lSignUp_Click(object sender, EventArgs e)
		{
			var signUp = new DlgUser
			{
				Text = "User sign up",
				Owner = this,
				StartPosition = FormStartPosition.CenterParent
			};

			if (signUp.ShowDialog() == DialogResult.OK)
			{
				Master.Instance.Users.Add(signUp.User);
			}
		}
	}
}
