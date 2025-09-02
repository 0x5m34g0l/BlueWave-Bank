namespace BlueWave_Bank
{
    partial class ClientsTransactionsScreen
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
            this.tpTransferBalances = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFromAccNumbers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbToAccNumbers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numTransferAmount = new System.Windows.Forms.NumericUpDown();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblCurrentBalanceTitle3 = new System.Windows.Forms.Label();
            this.lblCurrentBalance3 = new System.Windows.Forms.Label();
            this.tpTotalBalances = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            this.ClientsListView = new System.Windows.Forms.ListView();
            this.colAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBalances = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNumbersOfClients = new System.Windows.Forms.Label();
            this.tpWithdraw = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAccountNumbersToWithdraw = new System.Windows.Forms.ComboBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.numWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentBalanceTitle2 = new System.Windows.Forms.Label();
            this.lblCurrentBalance2 = new System.Windows.Forms.Label();
            this.tpDeposit = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.cbAccountNumbersToDeposit = new System.Windows.Forms.ComboBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.numDepositAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentBalanceTitle = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTransferBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransferAmount)).BeginInit();
            this.tpTotalBalances.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).BeginInit();
            this.tpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpTransferBalances
            // 
            this.tpTransferBalances.Controls.Add(this.lblCurrentBalance3);
            this.tpTransferBalances.Controls.Add(this.lblCurrentBalanceTitle3);
            this.tpTransferBalances.Controls.Add(this.btnTransfer);
            this.tpTransferBalances.Controls.Add(this.numTransferAmount);
            this.tpTransferBalances.Controls.Add(this.label7);
            this.tpTransferBalances.Controls.Add(this.cbToAccNumbers);
            this.tpTransferBalances.Controls.Add(this.label4);
            this.tpTransferBalances.Controls.Add(this.cbFromAccNumbers);
            this.tpTransferBalances.Controls.Add(this.label3);
            this.tpTransferBalances.Location = new System.Drawing.Point(4, 34);
            this.tpTransferBalances.Name = "tpTransferBalances";
            this.tpTransferBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransferBalances.Size = new System.Drawing.Size(794, 539);
            this.tpTransferBalances.TabIndex = 3;
            this.tpTransferBalances.Text = "Transfer Balances";
            this.tpTransferBalances.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "From Acc. Number";
            // 
            // cbFromAccNumbers
            // 
            this.cbFromAccNumbers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbFromAccNumbers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFromAccNumbers.ForeColor = System.Drawing.Color.White;
            this.cbFromAccNumbers.FormattingEnabled = true;
            this.cbFromAccNumbers.Location = new System.Drawing.Point(31, 66);
            this.cbFromAccNumbers.Name = "cbFromAccNumbers";
            this.cbFromAccNumbers.Size = new System.Drawing.Size(200, 33);
            this.cbFromAccNumbers.TabIndex = 50;
            this.cbFromAccNumbers.SelectedIndexChanged += new System.EventHandler(this.cbFromAccNumbers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(455, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "To Acc. Number";
            // 
            // cbToAccNumbers
            // 
            this.cbToAccNumbers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbToAccNumbers.Enabled = false;
            this.cbToAccNumbers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToAccNumbers.ForeColor = System.Drawing.Color.White;
            this.cbToAccNumbers.FormattingEnabled = true;
            this.cbToAccNumbers.Location = new System.Drawing.Point(460, 66);
            this.cbToAccNumbers.Name = "cbToAccNumbers";
            this.cbToAccNumbers.Size = new System.Drawing.Size(200, 33);
            this.cbToAccNumbers.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(26, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Transfer Amount";
            // 
            // numTransferAmount
            // 
            this.numTransferAmount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTransferAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTransferAmount.ForeColor = System.Drawing.Color.Transparent;
            this.numTransferAmount.Location = new System.Drawing.Point(31, 249);
            this.numTransferAmount.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numTransferAmount.Name = "numTransferAmount";
            this.numTransferAmount.Size = new System.Drawing.Size(200, 33);
            this.numTransferAmount.TabIndex = 54;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnTransfer.FlatAppearance.BorderSize = 2;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Location = new System.Drawing.Point(31, 340);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(200, 44);
            this.btnTransfer.TabIndex = 57;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblCurrentBalanceTitle3
            // 
            this.lblCurrentBalanceTitle3.AutoSize = true;
            this.lblCurrentBalanceTitle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceTitle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCurrentBalanceTitle3.Location = new System.Drawing.Point(28, 128);
            this.lblCurrentBalanceTitle3.Name = "lblCurrentBalanceTitle3";
            this.lblCurrentBalanceTitle3.Size = new System.Drawing.Size(177, 25);
            this.lblCurrentBalanceTitle3.TabIndex = 60;
            this.lblCurrentBalanceTitle3.Text = "Current Balance is:";
            this.lblCurrentBalanceTitle3.Visible = false;
            // 
            // lblCurrentBalance3
            // 
            this.lblCurrentBalance3.AutoSize = true;
            this.lblCurrentBalance3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance3.ForeColor = System.Drawing.Color.Green;
            this.lblCurrentBalance3.Location = new System.Drawing.Point(231, 128);
            this.lblCurrentBalance3.Name = "lblCurrentBalance3";
            this.lblCurrentBalance3.Size = new System.Drawing.Size(0, 25);
            this.lblCurrentBalance3.TabIndex = 61;
            // 
            // tpTotalBalances
            // 
            this.tpTotalBalances.Controls.Add(this.lblNumbersOfClients);
            this.tpTotalBalances.Controls.Add(this.ClientsListView);
            this.tpTotalBalances.Controls.Add(this.panel2);
            this.tpTotalBalances.Location = new System.Drawing.Point(4, 34);
            this.tpTotalBalances.Name = "tpTotalBalances";
            this.tpTotalBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tpTotalBalances.Size = new System.Drawing.Size(794, 539);
            this.tpTotalBalances.TabIndex = 2;
            this.tpTotalBalances.Text = "Total Balances";
            this.tpTotalBalances.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblTotalBalances);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 134);
            this.panel2.TabIndex = 0;
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalances.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTotalBalances.Location = new System.Drawing.Point(21, 40);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(0, 45);
            this.lblTotalBalances.TabIndex = 55;
            // 
            // ClientsListView
            // 
            this.ClientsListView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccountNumber,
            this.colFirstName,
            this.colBalances});
            this.ClientsListView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsListView.GridLines = true;
            this.ClientsListView.HideSelection = false;
            this.ClientsListView.HoverSelection = true;
            this.ClientsListView.Location = new System.Drawing.Point(105, 249);
            this.ClientsListView.Name = "ClientsListView";
            this.ClientsListView.Size = new System.Drawing.Size(561, 266);
            this.ClientsListView.TabIndex = 1;
            this.ClientsListView.UseCompatibleStateImageBehavior = false;
            this.ClientsListView.View = System.Windows.Forms.View.Details;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.Text = "Acc. Number";
            this.colAccountNumber.Width = 131;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.Width = 177;
            // 
            // colBalances
            // 
            this.colBalances.Text = "Balance ($)";
            this.colBalances.Width = 248;
            // 
            // lblNumbersOfClients
            // 
            this.lblNumbersOfClients.AutoSize = true;
            this.lblNumbersOfClients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbersOfClients.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumbersOfClients.Location = new System.Drawing.Point(100, 203);
            this.lblNumbersOfClients.Name = "lblNumbersOfClients";
            this.lblNumbersOfClients.Size = new System.Drawing.Size(0, 25);
            this.lblNumbersOfClients.TabIndex = 60;
            // 
            // tpWithdraw
            // 
            this.tpWithdraw.Controls.Add(this.lblCurrentBalance2);
            this.tpWithdraw.Controls.Add(this.lblCurrentBalanceTitle2);
            this.tpWithdraw.Controls.Add(this.label5);
            this.tpWithdraw.Controls.Add(this.numWithdrawAmount);
            this.tpWithdraw.Controls.Add(this.btnWithdraw);
            this.tpWithdraw.Controls.Add(this.cbAccountNumbersToWithdraw);
            this.tpWithdraw.Controls.Add(this.label6);
            this.tpWithdraw.Location = new System.Drawing.Point(4, 34);
            this.tpWithdraw.Name = "tpWithdraw";
            this.tpWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpWithdraw.Size = new System.Drawing.Size(794, 539);
            this.tpWithdraw.TabIndex = 1;
            this.tpWithdraw.Text = "Withdraw";
            this.tpWithdraw.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Acc. Number";
            // 
            // cbAccountNumbersToWithdraw
            // 
            this.cbAccountNumbersToWithdraw.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbAccountNumbersToWithdraw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountNumbersToWithdraw.ForeColor = System.Drawing.Color.White;
            this.cbAccountNumbersToWithdraw.FormattingEnabled = true;
            this.cbAccountNumbersToWithdraw.Location = new System.Drawing.Point(28, 64);
            this.cbAccountNumbersToWithdraw.Name = "cbAccountNumbersToWithdraw";
            this.cbAccountNumbersToWithdraw.Size = new System.Drawing.Size(200, 33);
            this.cbAccountNumbersToWithdraw.TabIndex = 55;
            this.cbAccountNumbersToWithdraw.SelectedIndexChanged += new System.EventHandler(this.cbAccountNumbersToWithdraw_SelectedIndexChanged);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnWithdraw.FlatAppearance.BorderSize = 2;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Location = new System.Drawing.Point(28, 323);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(200, 44);
            this.btnWithdraw.TabIndex = 56;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // numWithdrawAmount
            // 
            this.numWithdrawAmount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numWithdrawAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWithdrawAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWithdrawAmount.ForeColor = System.Drawing.Color.Transparent;
            this.numWithdrawAmount.Location = new System.Drawing.Point(28, 246);
            this.numWithdrawAmount.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numWithdrawAmount.Name = "numWithdrawAmount";
            this.numWithdrawAmount.Size = new System.Drawing.Size(200, 33);
            this.numWithdrawAmount.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(23, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Withdraw Amount";
            // 
            // lblCurrentBalanceTitle2
            // 
            this.lblCurrentBalanceTitle2.AutoSize = true;
            this.lblCurrentBalanceTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceTitle2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCurrentBalanceTitle2.Location = new System.Drawing.Point(23, 119);
            this.lblCurrentBalanceTitle2.Name = "lblCurrentBalanceTitle2";
            this.lblCurrentBalanceTitle2.Size = new System.Drawing.Size(177, 25);
            this.lblCurrentBalanceTitle2.TabIndex = 59;
            this.lblCurrentBalanceTitle2.Text = "Current Balance is:";
            this.lblCurrentBalanceTitle2.Visible = false;
            // 
            // lblCurrentBalance2
            // 
            this.lblCurrentBalance2.AutoSize = true;
            this.lblCurrentBalance2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance2.ForeColor = System.Drawing.Color.Green;
            this.lblCurrentBalance2.Location = new System.Drawing.Point(206, 119);
            this.lblCurrentBalance2.Name = "lblCurrentBalance2";
            this.lblCurrentBalance2.Size = new System.Drawing.Size(0, 25);
            this.lblCurrentBalance2.TabIndex = 60;
            // 
            // tpDeposit
            // 
            this.tpDeposit.Controls.Add(this.lblCurrentBalance);
            this.tpDeposit.Controls.Add(this.lblCurrentBalanceTitle);
            this.tpDeposit.Controls.Add(this.label1);
            this.tpDeposit.Controls.Add(this.numDepositAmount);
            this.tpDeposit.Controls.Add(this.btnDeposit);
            this.tpDeposit.Controls.Add(this.cbAccountNumbersToDeposit);
            this.tpDeposit.Controls.Add(this.label16);
            this.tpDeposit.Location = new System.Drawing.Point(4, 34);
            this.tpDeposit.Name = "tpDeposit";
            this.tpDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposit.Size = new System.Drawing.Size(794, 539);
            this.tpDeposit.TabIndex = 0;
            this.tpDeposit.Text = "Deposit";
            this.tpDeposit.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Location = new System.Drawing.Point(24, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "Acc. Number";
            // 
            // cbAccountNumbersToDeposit
            // 
            this.cbAccountNumbersToDeposit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbAccountNumbersToDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountNumbersToDeposit.ForeColor = System.Drawing.Color.White;
            this.cbAccountNumbersToDeposit.FormattingEnabled = true;
            this.cbAccountNumbersToDeposit.Location = new System.Drawing.Point(29, 65);
            this.cbAccountNumbersToDeposit.Name = "cbAccountNumbersToDeposit";
            this.cbAccountNumbersToDeposit.Size = new System.Drawing.Size(200, 33);
            this.cbAccountNumbersToDeposit.TabIndex = 48;
            this.cbAccountNumbersToDeposit.SelectedIndexChanged += new System.EventHandler(this.cbAccountNumbers_SelectedIndexChanged);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeposit.FlatAppearance.BorderSize = 2;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Location = new System.Drawing.Point(29, 324);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(200, 44);
            this.btnDeposit.TabIndex = 49;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // numDepositAmount
            // 
            this.numDepositAmount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDepositAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepositAmount.ForeColor = System.Drawing.Color.Transparent;
            this.numDepositAmount.Location = new System.Drawing.Point(29, 247);
            this.numDepositAmount.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numDepositAmount.Name = "numDepositAmount";
            this.numDepositAmount.Size = new System.Drawing.Size(200, 33);
            this.numDepositAmount.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(24, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Deposit Amount";
            // 
            // lblCurrentBalanceTitle
            // 
            this.lblCurrentBalanceTitle.AutoSize = true;
            this.lblCurrentBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCurrentBalanceTitle.Location = new System.Drawing.Point(24, 120);
            this.lblCurrentBalanceTitle.Name = "lblCurrentBalanceTitle";
            this.lblCurrentBalanceTitle.Size = new System.Drawing.Size(177, 25);
            this.lblCurrentBalanceTitle.TabIndex = 52;
            this.lblCurrentBalanceTitle.Text = "Current Balance is:";
            this.lblCurrentBalanceTitle.Visible = false;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.Green;
            this.lblCurrentBalance.Location = new System.Drawing.Point(207, 120);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(0, 25);
            this.lblCurrentBalance.TabIndex = 53;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDeposit);
            this.tabControl1.Controls.Add(this.tpWithdraw);
            this.tabControl1.Controls.Add(this.tpTotalBalances);
            this.tabControl1.Controls.Add(this.tpTransferBalances);
            this.tabControl1.Location = new System.Drawing.Point(343, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 577);
            this.tabControl1.TabIndex = 1;
            // 
            // ClientsTransactionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 589);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1166, 628);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1166, 628);
            this.Name = "ClientsTransactionsScreen";
            this.Text = "ClientsTransactionsScreen";
            this.Load += new System.EventHandler(this.ClientsTransactionsScreen_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tpTransferBalances.ResumeLayout(false);
            this.tpTransferBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransferAmount)).EndInit();
            this.tpTotalBalances.ResumeLayout(false);
            this.tpTotalBalances.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpWithdraw.ResumeLayout(false);
            this.tpWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).EndInit();
            this.tpDeposit.ResumeLayout(false);
            this.tpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpTransferBalances;
        private System.Windows.Forms.Label lblCurrentBalance3;
        private System.Windows.Forms.Label lblCurrentBalanceTitle3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.NumericUpDown numTransferAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbToAccNumbers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFromAccNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpTotalBalances;
        private System.Windows.Forms.Label lblNumbersOfClients;
        private System.Windows.Forms.ListView ClientsListView;
        private System.Windows.Forms.ColumnHeader colAccountNumber;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colBalances;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalBalances;
        private System.Windows.Forms.TabPage tpWithdraw;
        private System.Windows.Forms.Label lblCurrentBalance2;
        private System.Windows.Forms.Label lblCurrentBalanceTitle2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numWithdrawAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.ComboBox cbAccountNumbersToWithdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpDeposit;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblCurrentBalanceTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.ComboBox cbAccountNumbersToDeposit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl1;
    }
}