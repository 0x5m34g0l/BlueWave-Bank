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



namespace BlueWave_Bank
{
    public partial class ManageClientsScreen : MainScreen
    {
        public ManageClientsScreen()
        {
            InitializeComponent();

        }

        private void LoadAccountNumbersInUpdateScreen()
        {
            cbAccountNumbers.Items.Clear();
            List<BankClient> Clients = new List<BankClient>();
            Clients = BankClient.GetAllClients();

            foreach (BankClient C in Clients)
            {
                cbAccountNumbers.Items.Add(C.AccountNumber());
            }


        }

        private void ClientsScreen_Load(object sender, EventArgs e)
        {
            DisplayNumberOfClients();
            ViewClients();
            LoadAccountNumbersInUpdateScreen();
        }

        private int NumberOfClients()
        {
            return BankClient.GetAllClients().Count();
        }

        private void ViewClients()
        {
            List<BankClient> Clients = new List<BankClient>();
            Clients = BankClient.GetAllClients();

            for (int i = 0; i < Clients.Count(); i++)
            {
                string[] Record = BankClient.ConvertObjectToDataLine(Clients[i]).Split('#');
                ListViewItem Item = new ListViewItem(Record);
                Item.ForeColor = Color.Black;
                ClientsListView.Items.Add(Item);
            }

           
        }

        private void DisplayNumberOfClients()
        {
            lblNumberOfClients.Text = $"{NumberOfClients()} Client(s) Found";
        }

        private void DisplayClientByAccountNumber()
        {
            if (txtSearchAccountNumber.Text.Length == txtSearchAccountNumber.MaxLength)
            {
                if (BankClient.isClientExist(txtSearchAccountNumber.Text))
                {
                    BankClient Client = BankClient.Find(txtSearchAccountNumber.Text);
                    string[] Record = BankClient.ConvertObjectToDataLine(Client).Split('#');
                    ListViewItem Item = new ListViewItem(Record);
                    Item.ForeColor = Color.Black;
                    ClientsListView.Items.Clear();
                    ClientsListView.Items.Add(Item);
                    lblNumberOfClients.Text = "The Client is Found!";
                    pbSmileyFace.Image = Image.FromFile("C:/green_screen_final.png");
                }
            }
            else
            {
                ClientsListView.Items.Clear();
                DisplayNumberOfClients();
                pbSmileyFace.Image = null;
                ViewClients();
            }
            
        }

        private void txtSearchAccountNumber_TextChanged(object sender, EventArgs e)
        {
            DisplayClientByAccountNumber();
        }
        private void ValidateAllInputs()
        {
            int validCount = 0;

            // Example: replace these with your actual TextBoxes
            TextBox[] inputs = { txtAccNumber, txtPinCode, txtPhone, txtEmail, txtFirstName, txtLastName};

            foreach (TextBox tb in inputs)
            {
                if (tb == txtEmail) // special case: email must contain "@"
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

            // Update progress bar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = inputs.Length;
            progressBar1.Value = validCount;

            // Update label (math formula)
            Thread.Sleep(500);
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

        // Email has its own event method for validating.
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "The input must have a value, or contains @!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }

            ValidateAllInputs();
        }

        private void AddNewClient()
        {
            BankClient Client = new BankClient(BankClient.enMode.AddNew, "", "", "", "", txtAccNumber.Text, "", 0);
            Client.FirstName = txtFirstName.Text;
            Client.PinCode = txtPinCode.Text;
            Client.LastName = txtLastName.Text;
            Client.Email = txtEmail.Text;
            Client.Phone = txtPhone.Text;
            Client.Balance = (double)numBalance.Value;

            Client.Save();
        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            BankClient Client1 = BankClient.Find(txtAccNumber.Text);
            if (Client1 != null)
            {
                MessageBox.Show("The client is already exist, enter another one.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Client1 = null;
            }

            else
            {
                DialogResult dr = MessageBox.Show($"Are you sure to add client ({txtFirstName.Text})?",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    
                    AddNewClient();
                    MessageBox.Show("The client is added successfully!", "Success"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ClientsListView.Items.Clear();
            DisplayNumberOfClients();
            ViewClients();
            LoadAccountNumbersInUpdateScreen();
        }

        private void cbAccountNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankClient Client = BankClient.Find(cbAccountNumbers.SelectedItem.ToString().Trim());
            
            txtUpdtEmail.Text = Client.Email;
            txtUpdtFirstName.Text = Client.FirstName;
            txtUpdtLastName.Text = Client.LastName;
            txtUpdtPinCode.Text = Client.PinCode;
            txtUpdtPhone.Text = Client.Phone;
            numUpdtBalance.Value = (decimal)Client.Balance;
        }

        // Email has its own event method for validating.
        private void txtUpdtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdtEmail.Text) || !txtUpdtEmail.Text.Contains("@"))
            {
                e.Cancel = true;
                txtUpdtEmail.Focus();
                errorProvider1.SetError(txtUpdtEmail, "The input must have a value, or contains @!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdtEmail, "");
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show($"Are you sure to update client ({txtUpdtFirstName.Text})?",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                BankClient Client = new BankClient(BankClient.enMode.UpdateMode
                , txtUpdtFirstName.Text, txtUpdtLastName.Text, txtUpdtEmail.Text,
                 txtUpdtPhone.Text, cbAccountNumbers.SelectedItem.ToString(), txtUpdtPinCode.Text,
                Convert.ToDouble(numUpdtBalance.Value));
                Client.Save();

                MessageBox.Show("The client has been updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClientsListView.Items.Clear();
            DisplayNumberOfClients();
            ViewClients();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            BankClient Client = BankClient.Find(txtDltAccNumber.Text);
            if (Client!= null)
            {
                DialogResult dr = MessageBox.Show("Are you sure to DELETE this client?", "Confirm",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Client.Delete();
                    MessageBox.Show("The client is deleted successfully!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The account number does not exist!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ClientsListView.Items.Clear();
            DisplayNumberOfClients();
            ViewClients();
            LoadAccountNumbersInUpdateScreen();
        }
    }
}
