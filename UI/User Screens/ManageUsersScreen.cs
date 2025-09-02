using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BlueWave_Bank.UI;

namespace BlueWave_Bank
{
    public partial class ManageUsersScreen : MainScreen
    {

        // Local variable to set permissions, then assign to the User object
        private int _NewUserPermissions;
        private int _UpdatedUserPermissions;
        public ManageUsersScreen()
        {
            InitializeComponent();
        }

        private void SetNewUserPermissions()
        {
            _NewUserPermissions = 0;

            if (rbYes.Checked)
            {
                _NewUserPermissions = -1;
                chkClientsTransactions.Enabled = false;
                chkManageClients.Enabled = false;
                chkManageUsers.Enabled = false;

            }
            else
            {
                chkClientsTransactions.Enabled = true;
                chkManageClients.Enabled = true;
                chkManageUsers.Enabled = true;

                if (chkManageClients.Checked)
                    _NewUserPermissions += (int)User.enPermissions.eManageClients;

                if (chkClientsTransactions.Checked)

                    _NewUserPermissions += (int)User.enPermissions.eClientsTransactions;

                if (chkManageUsers.Checked)
                    _NewUserPermissions += (int)User.enPermissions.eManageUsers;
            }
        }
        private void SetUpdatedUserPermissions()
        {
            _UpdatedUserPermissions = 0;

            if (rbUpdtYes.Checked)
            {
                _UpdatedUserPermissions = -1;
                chkUpdtClientsTransactions.Enabled = false;
                chkUpdtManageClients.Enabled = false;
                chkUpdtManageUsers.Enabled = false;
            }
            else
            {
                chkUpdtClientsTransactions.Enabled = true;
                chkUpdtManageClients.Enabled = true;
                chkUpdtManageUsers.Enabled = true;

                if (chkUpdtManageClients.Checked)
                    _UpdatedUserPermissions += (int)User.enPermissions.eManageClients;

                if (chkUpdtClientsTransactions.Checked)

                    _UpdatedUserPermissions += (int)User.enPermissions.eClientsTransactions;

                if (chkUpdtManageUsers.Checked)
                    _UpdatedUserPermissions += (int)User.enPermissions.eManageUsers;
            }
        }
        private void LoadUsernamesInUpdateScreen()
        {
            cbUpdtUsernames.Items.Clear();
            List<User> Users = User.GetAllUsers();

            foreach (User U in Users)
            {
                cbUpdtUsernames.Items.Add(U.Username);
            }
        }

        private void ManageUsersScreen_Load(object sender, EventArgs e)
        {
            DisplayNumberOfUsers();
            ViewUsers();
            LoadUsernamesInUpdateScreen();
        }

        private int NumberOfUsers()
        {
            return User.GetAllUsers().Count();
        }

        private void ViewUsers()
        {
            UsersListView.Items.Clear();
            List<User> Users = User.GetAllUsers();

            for (int i = 0; i < Users.Count(); i++)
            {
                string[] Record = User.ConvertObjectToDataLine(Users[i]).Split('#');
                ListViewItem Item = new ListViewItem(Record);
                Item.ForeColor = Color.Black;
                UsersListView.Items.Add(Item);
            }
        }

        private void DisplayNumberOfUsers()
        {
            lblNumberOfUsers.Text = $"{NumberOfUsers()} User(s) Found";
        }

        private void DisplayUserByUsername()
        {
            if (!string.IsNullOrWhiteSpace(txtSearchUsername.Text))
            {
                if (User.isUserExist(txtSearchUsername.Text))
                {
                    User U = User.Find(txtSearchUsername.Text);
                    string[] Record = User.ConvertObjectToDataLine(U).Split('#');
                    ListViewItem Item = new ListViewItem(Record);
                    Item.ForeColor = Color.Black;
                    UsersListView.Items.Clear();
                    UsersListView.Items.Add(Item);
                    pbGreenSign.Image = Image.FromFile("C:/green_screen_final.png");
                    lblNumberOfUsers.Text = "The User is Found!";
                }
            }
            else
            {
                UsersListView.Items.Clear();
                pbGreenSign.Image = null;
                DisplayNumberOfUsers();
                ViewUsers();
            }
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            DisplayUserByUsername();
        }

        private void ValidateAllInputs()
        {
            int validCount = 0;

            // Example: replace these with your actual TextBoxes
            TextBox[] inputs = { txtFirstName, txtLastName, txtEmail, txtPhone, txtUsername, txtPassword };

            foreach (TextBox tb in inputs)
            {
                if (tb == txtEmail) // email must contain "@"
                {
                    if (!string.IsNullOrWhiteSpace(tb.Text) && tb.Text.Contains("@"))
                        validCount++;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(tb.Text))
                        validCount++;
                }
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = inputs.Length;
            progressBar1.Value = validCount;

            lblInputProgress.Text = Math.Ceiling((double)validCount / inputs.Length * 100) + "%";
        }

        private void CommonTextBoxs_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "The input must have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
            }
            ValidateAllInputs();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                e.Cancel = true;
                ((TextBox)(sender)).Focus();
                errorProvider1.SetError(((TextBox)(sender)), "The input must have a value, or contains @!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)(sender)), "");
            }
            ValidateAllInputs();
        }

        private void AddNewUser()
        {
            User U = new User(User.enMode.AddNew,
                txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhone.Text,
                txtUsername.Text,
                txtPassword.Text,
                _NewUserPermissions);

            U.Save();
            _NewUserPermissions = 0;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            User U = User.Find(txtUsername.Text);
            if (U != null)
            {
                MessageBox.Show("The user already exists, enter another one.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                U = null;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you sure to add user ({txtUsername.Text})?",
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    
                    AddNewUser();
                    MessageBox.Show("The user is added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            UsersListView.Items.Clear();
            DisplayNumberOfUsers();
            ViewUsers();
            LoadUsernamesInUpdateScreen();
        }

        private void cbUsernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            User U = User.Find(cbUpdtUsernames.SelectedItem.ToString().Trim());

            txtUpdtEmail.Text = U.Email;
            txtUpdtFirstName.Text = U.FirstName;
            txtUpdtLastName.Text = U.LastName;
            txtUpdtPassword.Text = U.Password;
            txtUpdtPhone.Text = U.Phone;
        }

        private void UpdateUser()
        {
            User U = new User(User.enMode.UpdateMode,
                txtUpdtFirstName.Text,
                txtUpdtLastName.Text,
                txtUpdtEmail.Text,
                txtUpdtPhone.Text,
                cbUpdtUsernames.SelectedItem.ToString(),
                txtUpdtPassword.Text,
                _UpdatedUserPermissions);

            U.Save();

            _UpdatedUserPermissions = 0;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Are you sure to update user ({txtUpdtFirstName.Text})?",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                UpdateUser();
                MessageBox.Show("The user has been updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UsersListView.Items.Clear();
            DisplayNumberOfUsers();
            ViewUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User U = User.Find(txtDltUsername.Text);
            if (U != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure to DELETE this user?", "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    U.Delete();
                    MessageBox.Show("The user is deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The username does not exist!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UsersListView.Items.Clear();
            DisplayNumberOfUsers();
            ViewUsers();
            LoadUsernamesInUpdateScreen();
        }

        private void SetNewUserPermissions(object sender, MouseEventArgs e)
        {
            SetNewUserPermissions();
        }

        private void SetUpdatedUserPermissions(object sender, MouseEventArgs e)
        {
            SetUpdatedUserPermissions();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            CommonTextBoxs_Validating(sender, e);
        }
    }
}

