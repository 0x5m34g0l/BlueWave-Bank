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
    public partial class ClientsTransactionsScreen : MainScreen
    {
        public ClientsTransactionsScreen()
        {
            InitializeComponent();
        }

        public int NumberOfClients()
        {
            return BankClient.GetAllClients().Count;
        }
        void LoadNumbersOfClients()
        {
            lblNumbersOfClients.Text = NumberOfClients() + " Client(s) Found" ;
        }

        void LoadClientsListView()
        {
            ClientsListView.Items.Clear();
            List<BankClient> Clients = BankClient.GetAllClients();
            for (int i = 0; i < Clients.Count; i++)
            {
                string[] Record = { Clients[i].AccountNumber(), Clients[i].FirstName,
                    Clients[i].Balance.ToString() };
                ListViewItem Item = new ListViewItem(Record);
                ClientsListView.Items.Add(Item);
            }
        }
        private void ClientsTransactionsScreen_Load(object sender, EventArgs e)
        {
            LoadAccountNumbersToDeposit();
            LoadAccountNumbersToWithdraw();
            LoadTotalBalances();
            LoadNumbersOfClients();
            LoadClientsListView();
            LoadAccountNumbersForTransfer();
        }

        void UpdateTotalBalancesTab()
        {
            LoadTotalBalances();
            LoadNumbersOfClients();
            LoadClientsListView();
        }

        private void LoadAccountNumbersToDeposit()
        {
            List<BankClient> Clients = new List<BankClient>();
            Clients = BankClient.GetAllClients();

            for (int i = 0; i <  Clients.Count; i++)
            {
                cbAccountNumbersToDeposit.Items.Add(Clients[i].AccountNumber());
            }
        }
        private void LoadAccountNumbersToWithdraw()
        {
            List<BankClient> Clients = new List<BankClient>();
            Clients = BankClient.GetAllClients();

            for (int i = 0; i < Clients.Count; i++)
            {
                cbAccountNumbersToWithdraw.Items.Add(Clients[i].AccountNumber());
            }
        }
        private void cbAccountNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankClient Client = BankClient.Find(cbAccountNumbersToDeposit.SelectedItem.ToString());
            lblCurrentBalanceTitle.Visible = true; 
            lblCurrentBalance.Text = "$" + Client.Balance;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to perform this transaction?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                BankClient Client = BankClient.Find(cbAccountNumbersToDeposit.SelectedItem.ToString());
                Client.Deposit((Convert.ToDouble(numDepositAmount.Value)));
                MessageBox.Show($"Amount has been deposited {numDepositAmount.Value} successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateTotalBalancesTab();
        }

        private void cbAccountNumbersToWithdraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankClient Client = BankClient.Find(cbAccountNumbersToWithdraw.SelectedItem.ToString());
            lblCurrentBalanceTitle2.Visible = true;
            lblCurrentBalance2.Text = "$" + Client.Balance;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to perform this transaction?", "Confirm",
    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                BankClient Client = BankClient.Find(cbAccountNumbersToWithdraw.SelectedItem.ToString());
                if (Client.Balance < (double)numWithdrawAmount.Value)
                {
                    MessageBox.Show("The amount exceeded the balance!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Client.Withdraw((Convert.ToDouble(numWithdrawAmount.Value)));
                    MessageBox.Show($"Amount has been withdrawn {numWithdrawAmount.Value} successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            UpdateTotalBalancesTab();
        }
         
        private void LoadTotalBalances()
        {
            lblTotalBalances.Text = $"Total Balances is: ${BankClient.TotalBalances()}";
        }

    // Generic method
        private void LoadAccountNumbersForTransfer(ComboBox cb)
        {
            List<BankClient> Clients = BankClient.GetAllClients();
            for(int i = 0; i < Clients.Count; i++)
            {
                cb.Items.Add(Clients[i].AccountNumber());
            }
        }

        private void LoadAccountNumbersForTransfer()
        {
            LoadAccountNumbersForTransfer(cbFromAccNumbers);
            LoadAccountNumbersForTransfer(cbToAccNumbers);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to perform this transaction?", "Confirm",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                BankClient Client1 = BankClient.Find(cbFromAccNumbers.SelectedItem.ToString());
                BankClient Client2 = BankClient.Find(cbToAccNumbers.SelectedItem.ToString());
                if (Client1.Balance < (double)numTransferAmount.Value)
                {
                    MessageBox.Show("The amount exceeded the balance!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Client1.Transfer((double)numTransferAmount.Value, Client2);
                    MessageBox.Show($"Amount has been transfered {numTransferAmount.Value} successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            UpdateTotalBalancesTab();
        }

        private void cbFromAccNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankClient Client = BankClient.Find(cbFromAccNumbers.SelectedItem.ToString());
            lblCurrentBalanceTitle3.Visible = true;
            lblCurrentBalance3.Text = "$" + Client.Balance;
            cbToAccNumbers.Items.Remove(cbFromAccNumbers.SelectedItem);
            cbToAccNumbers.Enabled = true;
        }
    }
}
