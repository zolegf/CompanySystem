using System;
using System.Windows.Forms;
using CompanySystem;

namespace CompanyManager
{
	public partial class DlgSignIn : Form
	{
		//private Form _admin = new WndAdmin();
		//private Form _manager = new WndManager();
		//private Form _user = new WndMain();

		public DlgSignIn()
		{
			InitializeComponent();
		}

		private void OnClickSignUp(object sender, EventArgs e)
		{
			var SignUp = new DlgSignUp();
			SignUp.ShowDialog();
		}

		private void onClickLogIn(object sender, EventArgs e)
		{
			User user = Master.Instance.Authenticate(txtUsername.Text, txtPassword.Text);
			if (user == null)
			{
				MessageBox.Show("User sa unetim kredencijalima ne postoji u evidenciji!");
				return;
			}

			if (user is Admin)
			{
				Hide();
				new WndAdmin { Owner = this, StartPosition = FormStartPosition.CenterParent }.ShowDialog();
			}
			else if (user is Manager)
			{
				Hide();
				new WndManager { Owner = this, StartPosition = FormStartPosition.CenterParent }.ShowDialog();
			}
			else
			{
				Hide();
				new WndEmployee { Owner = this, StartPosition = FormStartPosition.CenterParent }.ShowDialog();
			}

			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void DlgSignIn_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				onClickLogIn(this, EventArgs.Empty);
		}
	}
}
