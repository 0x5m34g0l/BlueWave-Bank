using BlueWave_Bank.UI.General_Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueWave_Bank
{
    public partial class LoginScreen : MainScreen
    {

        private int _NumberOfTrials = 3;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)(sender)).Text))
            {
                e.Cancel = true;
                ((TextBox)(sender)).Focus();
                errorProvider1.SetError(((TextBox)(sender)), "The input must have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)(sender)), "");
            }
        }

        private void RunHomeScreen()
        {
            HomeScreen HomeScreen1 = new HomeScreen();
            HomeScreen1.ShowDialog();
        }

        private void ShowNumberOfTrials(int NumberOfTrials)
        {
            lblNumberOfTrials.Text =
                $"Invalid Username/Password!!" + Environment.NewLine +
                "You have " + NumberOfTrials + " attempts before your account getting locked.";
        }

        private void ShowLockMessage()
        {
            gbLogin.Enabled = false;
            lblNumberOfTrials.Text = "Your account is locked. Contact System Administrator.";
        }

        private void Login()
        {
            Global.CurrentUser = User.Find(txtUsername.Text,txtPassword.Text);
            if (Global.CurrentUser != null)
            {
                RunHomeScreen();
                return;
            }
            else
            {
                if (_NumberOfTrials == 1)
                {
                    ShowLockMessage();
                    return;
                }
                ShowNumberOfTrials(_NumberOfTrials - 1);
                _NumberOfTrials--;
            }

            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
