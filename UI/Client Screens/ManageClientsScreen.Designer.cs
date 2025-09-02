namespace BlueWave_Bank
{
    partial class ManageClientsScreen
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
            this.components = new System.ComponentModel.Container();
            this.tcClients = new System.Windows.Forms.TabControl();
            this.tpShowClients = new System.Windows.Forms.TabPage();
            this.pbSmileyFace = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchAccountNumber = new System.Windows.Forms.TextBox();
            this.lblNumberOfClients = new System.Windows.Forms.Label();
            this.ClientsListView = new System.Windows.Forms.ListView();
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPinCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpAddNewClient = new System.Windows.Forms.TabPage();
            this.lblInputProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.tpUpdateClient = new System.Windows.Forms.TabPage();
            this.cbAccountNumbers = new System.Windows.Forms.ComboBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.numUpdtBalance = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdtEmail = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdtPhone = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdtFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUpdtLastName = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUpdtPinCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tpDeleteClient = new System.Windows.Forms.TabPage();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDltAccNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcClients.SuspendLayout();
            this.tpShowClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmileyFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpAddNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.tpUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdtBalance)).BeginInit();
            this.tpDeleteClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClients
            // 
            this.tcClients.Controls.Add(this.tpShowClients);
            this.tcClients.Controls.Add(this.tpAddNewClient);
            this.tcClients.Controls.Add(this.tpUpdateClient);
            this.tcClients.Controls.Add(this.tpDeleteClient);
            this.tcClients.Location = new System.Drawing.Point(343, 12);
            this.tcClients.Name = "tcClients";
            this.tcClients.SelectedIndex = 0;
            this.tcClients.Size = new System.Drawing.Size(809, 577);
            this.tcClients.TabIndex = 1;
            // 
            // tpShowClients
            // 
            this.tpShowClients.Controls.Add(this.pbSmileyFace);
            this.tpShowClients.Controls.Add(this.pictureBox1);
            this.tpShowClients.Controls.Add(this.panel2);
            this.tpShowClients.Controls.Add(this.label1);
            this.tpShowClients.Controls.Add(this.txtSearchAccountNumber);
            this.tpShowClients.Controls.Add(this.lblNumberOfClients);
            this.tpShowClients.Controls.Add(this.ClientsListView);
            this.tpShowClients.Location = new System.Drawing.Point(4, 34);
            this.tpShowClients.Name = "tpShowClients";
            this.tpShowClients.Size = new System.Drawing.Size(801, 539);
            this.tpShowClients.TabIndex = 0;
            this.tpShowClients.Text = "Show Clients";
            this.tpShowClients.UseVisualStyleBackColor = true;
            // 
            // pbSmileyFace
            // 
            this.pbSmileyFace.Location = new System.Drawing.Point(193, 161);
            this.pbSmileyFace.Name = "pbSmileyFace";
            this.pbSmileyFace.Size = new System.Drawing.Size(20, 20);
            this.pbSmileyFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSmileyFace.TabIndex = 6;
            this.pbSmileyFace.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlueWave_Bank.Properties.Resources.search_image_final1;
            this.pictureBox1.Location = new System.Drawing.Point(209, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(13, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Acc. Number";
            // 
            // txtSearchAccountNumber
            // 
            this.txtSearchAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchAccountNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccountNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSearchAccountNumber.Location = new System.Drawing.Point(13, 57);
            this.txtSearchAccountNumber.MaxLength = 4;
            this.txtSearchAccountNumber.Multiline = true;
            this.txtSearchAccountNumber.Name = "txtSearchAccountNumber";
            this.txtSearchAccountNumber.Size = new System.Drawing.Size(200, 26);
            this.txtSearchAccountNumber.TabIndex = 2;
            this.txtSearchAccountNumber.TextChanged += new System.EventHandler(this.txtSearchAccountNumber_TextChanged);
            // 
            // lblNumberOfClients
            // 
            this.lblNumberOfClients.AutoSize = true;
            this.lblNumberOfClients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfClients.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfClients.Location = new System.Drawing.Point(8, 161);
            this.lblNumberOfClients.Name = "lblNumberOfClients";
            this.lblNumberOfClients.Size = new System.Drawing.Size(0, 25);
            this.lblNumberOfClients.TabIndex = 1;
            // 
            // ClientsListView
            // 
            this.ClientsListView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPhone,
            this.colAccNumber,
            this.colPinCode,
            this.colBalance});
            this.ClientsListView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsListView.GridLines = true;
            this.ClientsListView.HideSelection = false;
            this.ClientsListView.HoverSelection = true;
            this.ClientsListView.Location = new System.Drawing.Point(13, 228);
            this.ClientsListView.Name = "ClientsListView";
            this.ClientsListView.Size = new System.Drawing.Size(769, 281);
            this.ClientsListView.TabIndex = 0;
            this.ClientsListView.UseCompatibleStateImageBehavior = false;
            this.ClientsListView.View = System.Windows.Forms.View.Details;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.Width = 123;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 116;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 140;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone";
            this.colPhone.Width = 103;
            // 
            // colAccNumber
            // 
            this.colAccNumber.Text = "Acc. Number";
            this.colAccNumber.Width = 128;
            // 
            // colPinCode
            // 
            this.colPinCode.Text = "Pin Code";
            this.colPinCode.Width = 92;
            // 
            // colBalance
            // 
            this.colBalance.Text = "Balance ($)";
            this.colBalance.Width = 247;
            // 
            // tpAddNewClient
            // 
            this.tpAddNewClient.Controls.Add(this.lblInputProgress);
            this.tpAddNewClient.Controls.Add(this.progressBar1);
            this.tpAddNewClient.Controls.Add(this.btnAddNewClient);
            this.tpAddNewClient.Controls.Add(this.numBalance);
            this.tpAddNewClient.Controls.Add(this.label9);
            this.tpAddNewClient.Controls.Add(this.panel8);
            this.tpAddNewClient.Controls.Add(this.label8);
            this.tpAddNewClient.Controls.Add(this.txtEmail);
            this.tpAddNewClient.Controls.Add(this.panel7);
            this.tpAddNewClient.Controls.Add(this.label7);
            this.tpAddNewClient.Controls.Add(this.txtPhone);
            this.tpAddNewClient.Controls.Add(this.panel6);
            this.tpAddNewClient.Controls.Add(this.panel5);
            this.tpAddNewClient.Controls.Add(this.label6);
            this.tpAddNewClient.Controls.Add(this.txtFirstName);
            this.tpAddNewClient.Controls.Add(this.label5);
            this.tpAddNewClient.Controls.Add(this.txtLastName);
            this.tpAddNewClient.Controls.Add(this.panel4);
            this.tpAddNewClient.Controls.Add(this.label4);
            this.tpAddNewClient.Controls.Add(this.txtPinCode);
            this.tpAddNewClient.Controls.Add(this.panel3);
            this.tpAddNewClient.Controls.Add(this.label3);
            this.tpAddNewClient.Controls.Add(this.txtAccNumber);
            this.tpAddNewClient.Location = new System.Drawing.Point(4, 34);
            this.tpAddNewClient.Name = "tpAddNewClient";
            this.tpAddNewClient.Size = new System.Drawing.Size(801, 539);
            this.tpAddNewClient.TabIndex = 1;
            this.tpAddNewClient.Text = "Add New Client";
            this.tpAddNewClient.UseVisualStyleBackColor = true;
            // 
            // lblInputProgress
            // 
            this.lblInputProgress.AutoSize = true;
            this.lblInputProgress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputProgress.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblInputProgress.Location = new System.Drawing.Point(653, 186);
            this.lblInputProgress.Name = "lblInputProgress";
            this.lblInputProgress.Size = new System.Drawing.Size(39, 25);
            this.lblInputProgress.TabIndex = 26;
            this.lblInputProgress.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar1.Location = new System.Drawing.Point(569, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 25);
            this.progressBar1.TabIndex = 25;
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewClient.FlatAppearance.BorderSize = 2;
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.Location = new System.Drawing.Point(297, 429);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(200, 44);
            this.btnAddNewClient.TabIndex = 24;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = false;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // numBalance
            // 
            this.numBalance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBalance.ForeColor = System.Drawing.Color.Transparent;
            this.numBalance.Location = new System.Drawing.Point(44, 437);
            this.numBalance.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numBalance.Name = "numBalance";
            this.numBalance.Size = new System.Drawing.Size(200, 33);
            this.numBalance.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(39, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Balance";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(44, 355);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 3);
            this.panel8.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(39, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtEmail.Location = new System.Drawing.Point(44, 332);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(297, 355);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 3);
            this.panel7.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(292, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPhone.Location = new System.Drawing.Point(297, 332);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtPhone.TabIndex = 15;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.CommonTextBoxs_Validating);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(44, 247);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 3);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(297, 247);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(39, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtFirstName.Location = new System.Drawing.Point(44, 224);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtFirstName.TabIndex = 12;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.CommonTextBoxs_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(292, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtLastName.Location = new System.Drawing.Point(297, 224);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtLastName.TabIndex = 12;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.CommonTextBoxs_Validating);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(297, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 3);
            this.panel4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(292, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pin Code";
            // 
            // txtPinCode
            // 
            this.txtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPinCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPinCode.Location = new System.Drawing.Point(297, 60);
            this.txtPinCode.MaxLength = 4;
            this.txtPinCode.Multiline = true;
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(200, 26);
            this.txtPinCode.TabIndex = 9;
            this.txtPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.CommonTextBoxs_Validating);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(44, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(39, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Acc. Number";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtAccNumber.Location = new System.Drawing.Point(44, 60);
            this.txtAccNumber.MaxLength = 50;
            this.txtAccNumber.Multiline = true;
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(200, 26);
            this.txtAccNumber.TabIndex = 6;
            this.txtAccNumber.Validating += new System.ComponentModel.CancelEventHandler(this.CommonTextBoxs_Validating);
            // 
            // tpUpdateClient
            // 
            this.tpUpdateClient.Controls.Add(this.cbAccountNumbers);
            this.tpUpdateClient.Controls.Add(this.btnUpdateClient);
            this.tpUpdateClient.Controls.Add(this.numUpdtBalance);
            this.tpUpdateClient.Controls.Add(this.label10);
            this.tpUpdateClient.Controls.Add(this.panel9);
            this.tpUpdateClient.Controls.Add(this.label11);
            this.tpUpdateClient.Controls.Add(this.txtUpdtEmail);
            this.tpUpdateClient.Controls.Add(this.panel10);
            this.tpUpdateClient.Controls.Add(this.label12);
            this.tpUpdateClient.Controls.Add(this.txtUpdtPhone);
            this.tpUpdateClient.Controls.Add(this.panel11);
            this.tpUpdateClient.Controls.Add(this.panel12);
            this.tpUpdateClient.Controls.Add(this.label13);
            this.tpUpdateClient.Controls.Add(this.txtUpdtFirstName);
            this.tpUpdateClient.Controls.Add(this.label14);
            this.tpUpdateClient.Controls.Add(this.txtUpdtLastName);
            this.tpUpdateClient.Controls.Add(this.panel13);
            this.tpUpdateClient.Controls.Add(this.label15);
            this.tpUpdateClient.Controls.Add(this.txtUpdtPinCode);
            this.tpUpdateClient.Controls.Add(this.label16);
            this.tpUpdateClient.Location = new System.Drawing.Point(4, 34);
            this.tpUpdateClient.Name = "tpUpdateClient";
            this.tpUpdateClient.Size = new System.Drawing.Size(801, 539);
            this.tpUpdateClient.TabIndex = 2;
            this.tpUpdateClient.Text = "Update Client";
            this.tpUpdateClient.UseVisualStyleBackColor = true;
            // 
            // cbAccountNumbers
            // 
            this.cbAccountNumbers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbAccountNumbers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountNumbers.ForeColor = System.Drawing.Color.White;
            this.cbAccountNumbers.FormattingEnabled = true;
            this.cbAccountNumbers.Location = new System.Drawing.Point(43, 56);
            this.cbAccountNumbers.Name = "cbAccountNumbers";
            this.cbAccountNumbers.Size = new System.Drawing.Size(200, 33);
            this.cbAccountNumbers.TabIndex = 46;
            this.cbAccountNumbers.SelectedIndexChanged += new System.EventHandler(this.cbAccountNumbers_SelectedIndexChanged);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClient.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateClient.FlatAppearance.BorderSize = 2;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.Location = new System.Drawing.Point(296, 428);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(200, 44);
            this.btnUpdateClient.TabIndex = 45;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // numUpdtBalance
            // 
            this.numUpdtBalance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numUpdtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdtBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpdtBalance.ForeColor = System.Drawing.Color.Transparent;
            this.numUpdtBalance.Location = new System.Drawing.Point(43, 436);
            this.numUpdtBalance.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numUpdtBalance.Name = "numUpdtBalance";
            this.numUpdtBalance.Size = new System.Drawing.Size(200, 33);
            this.numUpdtBalance.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(38, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Balance";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(43, 354);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 3);
            this.panel9.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(38, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 25);
            this.label11.TabIndex = 41;
            this.label11.Text = "Email";
            // 
            // txtUpdtEmail
            // 
            this.txtUpdtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdtEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUpdtEmail.Location = new System.Drawing.Point(43, 331);
            this.txtUpdtEmail.MaxLength = 50;
            this.txtUpdtEmail.Multiline = true;
            this.txtUpdtEmail.Name = "txtUpdtEmail";
            this.txtUpdtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtUpdtEmail.TabIndex = 40;
            this.txtUpdtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdtEmail_Validating);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(296, 354);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 3);
            this.panel10.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Location = new System.Drawing.Point(291, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Phone";
            // 
            // txtUpdtPhone
            // 
            this.txtUpdtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdtPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdtPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUpdtPhone.Location = new System.Drawing.Point(296, 331);
            this.txtUpdtPhone.MaxLength = 50;
            this.txtUpdtPhone.Multiline = true;
            this.txtUpdtPhone.Name = "txtUpdtPhone";
            this.txtUpdtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtUpdtPhone.TabIndex = 37;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel11.ForeColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(43, 246);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 3);
            this.panel11.TabIndex = 36;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel12.ForeColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(296, 246);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 3);
            this.panel12.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(38, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "First Name";
            // 
            // txtUpdtFirstName
            // 
            this.txtUpdtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdtFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdtFirstName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUpdtFirstName.Location = new System.Drawing.Point(43, 223);
            this.txtUpdtFirstName.MaxLength = 50;
            this.txtUpdtFirstName.Multiline = true;
            this.txtUpdtFirstName.Name = "txtUpdtFirstName";
            this.txtUpdtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtUpdtFirstName.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Location = new System.Drawing.Point(291, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Last Name";
            // 
            // txtUpdtLastName
            // 
            this.txtUpdtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdtLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdtLastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUpdtLastName.Location = new System.Drawing.Point(296, 223);
            this.txtUpdtLastName.MaxLength = 50;
            this.txtUpdtLastName.Multiline = true;
            this.txtUpdtLastName.Name = "txtUpdtLastName";
            this.txtUpdtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtUpdtLastName.TabIndex = 31;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel13.ForeColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(296, 82);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 3);
            this.panel13.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Location = new System.Drawing.Point(291, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Pin Code";
            // 
            // txtUpdtPinCode
            // 
            this.txtUpdtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdtPinCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdtPinCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUpdtPinCode.Location = new System.Drawing.Point(296, 59);
            this.txtUpdtPinCode.MaxLength = 4;
            this.txtUpdtPinCode.Multiline = true;
            this.txtUpdtPinCode.Name = "txtUpdtPinCode";
            this.txtUpdtPinCode.Size = new System.Drawing.Size(200, 26);
            this.txtUpdtPinCode.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Location = new System.Drawing.Point(38, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Acc. Number";
            // 
            // tpDeleteClient
            // 
            this.tpDeleteClient.Controls.Add(this.btnDeleteClient);
            this.tpDeleteClient.Controls.Add(this.pictureBox2);
            this.tpDeleteClient.Controls.Add(this.label18);
            this.tpDeleteClient.Controls.Add(this.panel14);
            this.tpDeleteClient.Controls.Add(this.label17);
            this.tpDeleteClient.Controls.Add(this.txtDltAccNumber);
            this.tpDeleteClient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDeleteClient.Location = new System.Drawing.Point(4, 34);
            this.tpDeleteClient.Name = "tpDeleteClient";
            this.tpDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteClient.Size = new System.Drawing.Size(801, 539);
            this.tpDeleteClient.TabIndex = 3;
            this.tpDeleteClient.Text = "Delete Client";
            this.tpDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteClient.FlatAppearance.BorderSize = 2;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.Location = new System.Drawing.Point(196, 247);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(374, 44);
            this.btnDeleteClient.TabIndex = 46;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlueWave_Bank.Properties.Resources.danger_img;
            this.pictureBox2.Location = new System.Drawing.Point(25, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(86, 449);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(580, 60);
            this.label18.TabIndex = 12;
            this.label18.Text = "NOTE: This action is permanent – once a client is deleted, \r\ntheir data cannot be" +
    " recovered.";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel14.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.ForeColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(196, 212);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(374, 3);
            this.panel14.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Location = new System.Drawing.Point(189, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(391, 37);
            this.label17.TabIndex = 10;
            this.label17.Text = "Enter Acc. Number To Delete:";
            // 
            // txtDltAccNumber
            // 
            this.txtDltAccNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDltAccNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDltAccNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtDltAccNumber.Location = new System.Drawing.Point(196, 173);
            this.txtDltAccNumber.MaxLength = 50;
            this.txtDltAccNumber.Multiline = true;
            this.txtDltAccNumber.Name = "txtDltAccNumber";
            this.txtDltAccNumber.Size = new System.Drawing.Size(384, 39);
            this.txtDltAccNumber.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManageClientsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 588);
            this.Controls.Add(this.tcClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1170, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1170, 627);
            this.Name = "ManageClientsScreen";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.ClientsScreen_Load);
            this.Controls.SetChildIndex(this.tcClients, 0);
            this.tcClients.ResumeLayout(false);
            this.tpShowClients.ResumeLayout(false);
            this.tpShowClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmileyFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpAddNewClient.ResumeLayout(false);
            this.tpAddNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.tpUpdateClient.ResumeLayout(false);
            this.tpUpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdtBalance)).EndInit();
            this.tpDeleteClient.ResumeLayout(false);
            this.tpDeleteClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClients;
        private System.Windows.Forms.TabPage tpShowClients;
        private System.Windows.Forms.TabPage tpAddNewClient;
        private System.Windows.Forms.TabPage tpUpdateClient;
        private System.Windows.Forms.ListView ClientsListView;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colAccNumber;
        private System.Windows.Forms.ColumnHeader colPinCode;
        private System.Windows.Forms.ColumnHeader colBalance;
        private System.Windows.Forms.Label lblNumberOfClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchAccountNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSmileyFace;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblInputProgress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.NumericUpDown numUpdtBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdtEmail;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdtPhone;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdtFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUpdtLastName;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUpdtPinCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbAccountNumbers;
        private System.Windows.Forms.TabPage tpDeleteClient;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDltAccNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDeleteClient;
    }
}