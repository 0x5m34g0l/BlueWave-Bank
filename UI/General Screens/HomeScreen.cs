
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BlueWave_Bank.UI.General_Screens
{
    public partial class HomeScreen : MainScreen
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        void CheckPermissions()
        {
            if (Global.CurrentUser.Permissions == -1)
                return;

            if (!Global.CurrentUser.HasPermissions((int)User.enPermissions.eManageClients))
            {
                btnManageClients.Enabled = false;
                btnManageClients.BackColor = Color.DarkRed;
                btnManageClients.ForeColor = Color.White;
            }

            if (!Global.CurrentUser.HasPermissions((int)User.enPermissions.eClientsTransactions))
            {
                btnClientsTransactions.Enabled = false;
                btnClientsTransactions.BackColor = Color.DarkRed;
                btnClientsTransactions.ForeColor = Color.White;
            }

            if (!Global.CurrentUser.HasPermissions((int)User.enPermissions.eManageUsers))
            {
                btnManageUsers.Enabled = false;
                btnManageUsers.BackColor = Color.DarkRed;
                btnManageUsers.ForeColor = Color.White;
            }
        }
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            CheckPermissions();
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            ManageClientsScreen ManageClientsScreen1 = new ManageClientsScreen();
            ManageClientsScreen1.ShowDialog();
        }

        private void btnClientsTransactions_Click(object sender, EventArgs e)
        {
            ClientsTransactionsScreen ClientsTransactionsScreen1 = new ClientsTransactionsScreen();
            ClientsTransactionsScreen1.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersScreen ManageUsersScreen1 = new ManageUsersScreen();
            ManageUsersScreen1.ShowDialog();
        }

        private void btnExit_Click(object sender, MouseEventArgs e)
        {
            // Free the global object from data
            Global.CurrentUser = null;

            this.Hide();
            LoginScreen LoginScreen1 = new LoginScreen();
            LoginScreen1.ShowDialog();
        }
    }
}
