namespace BlueWave_Bank
{
    partial class ManageUsersScreen
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
            this.tpShowUsers = new System.Windows.Forms.TabPage();
            this.pbGreenSign = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.UsersListView = new System.Windows.Forms.ListView();
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPermissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpAddNewUser = new System.Windows.Forms.TabPage();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.chkClientsTransactions = new System.Windows.Forms.CheckBox();
            this.chkManageClients = new System.Windows.Forms.CheckBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInputProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAddNewUser = new System.Windows.Forms.Button();
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tpUpdateUser = new System.Windows.Forms.TabPage();
            this.gbUpdtPermissions = new System.Windows.Forms.GroupBox();
            this.chkUpdtManageUsers = new System.Windows.Forms.CheckBox();
            this.chkUpdtClientsTransactions = new System.Windows.Forms.CheckBox();
            this.chkUpdtManageClients = new System.Windows.Forms.CheckBox();
            this.rdUpdtNo = new System.Windows.Forms.RadioButton();
            this.rbUpdtYes = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUpdtUsernames = new System.Windows.Forms.ComboBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
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
            this.txtUpdtPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tpDeleteUser = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDltUsername = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcClients.SuspendLayout();
            this.tpShowUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpAddNewUser.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            this.tpUpdateUser.SuspendLayout();
            this.gbUpdtPermissions.SuspendLayout();
            this.tpDeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClients
            // 
            this.tcClients.Controls.Add(this.tpShowUsers);
            this.tcClients.Controls.Add(this.tpAddNewUser);
            this.tcClients.Controls.Add(this.tpUpdateUser);
            this.tcClients.Controls.Add(this.tpDeleteUser);
            this.tcClients.Location = new System.Drawing.Point(343, 9);
            this.tcClients.Name = "tcClients";
            this.tcClients.SelectedIndex = 0;
            this.tcClients.Size = new System.Drawing.Size(923, 577);
            this.tcClients.TabIndex = 2;
            // 
            // tpShowUsers
            // 
            this.tpShowUsers.Controls.Add(this.pbGreenSign);
            this.tpShowUsers.Controls.Add(this.pictureBox1);
            this.tpShowUsers.Controls.Add(this.panel2);
            this.tpShowUsers.Controls.Add(this.label1);
            this.tpShowUsers.Controls.Add(this.txtSearchUsername);
            this.tpShowUsers.Controls.Add(this.lblNumberOfUsers);
            this.tpShowUsers.Controls.Add(this.UsersListView);
            this.tpShowUsers.Location = new System.Drawing.Point(4, 34);
            this.tpShowUsers.Name = "tpShowUsers";
            this.tpShowUsers.Size = new System.Drawing.Size(915, 539);
            this.tpShowUsers.TabIndex = 0;
            this.tpShowUsers.Text = "Show Users";
            this.tpShowUsers.UseVisualStyleBackColor = true;
            // 
            // pbGreenSign
            // 
            this.pbGreenSign.Location = new System.Drawing.Point(193, 161);
            this.pbGreenSign.Name = "pbGreenSign";
            this.pbGreenSign.Size = new System.Drawing.Size(20, 20);
            this.pbGreenSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGreenSign.TabIndex = 6;
            this.pbGreenSign.TabStop = false;
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
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search User name";
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSearchUsername.Location = new System.Drawing.Point(13, 57);
            this.txtSearchUsername.MaxLength = 10;
            this.txtSearchUsername.Multiline = true;
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(200, 26);
            this.txtSearchUsername.TabIndex = 2;
            this.txtSearchUsername.TextChanged += new System.EventHandler(this.txtSearchUsername_TextChanged);
            // 
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.AutoSize = true;
            this.lblNumberOfUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUsers.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfUsers.Location = new System.Drawing.Point(8, 161);
            this.lblNumberOfUsers.Name = "lblNumberOfUsers";
            this.lblNumberOfUsers.Size = new System.Drawing.Size(0, 25);
            this.lblNumberOfUsers.TabIndex = 1;
            // 
            // UsersListView
            // 
            this.UsersListView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UsersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPhone,
            this.colUsername,
            this.colPassword,
            this.colPermissions});
            this.UsersListView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersListView.GridLines = true;
            this.UsersListView.HideSelection = false;
            this.UsersListView.Location = new System.Drawing.Point(13, 228);
            this.UsersListView.MultiSelect = false;
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(872, 263);
            this.UsersListView.TabIndex = 0;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.View = System.Windows.Forms.View.Details;
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
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 119;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.Width = 139;
            // 
            // colPermissions
            // 
            this.colPermissions.Text = "Permissions";
            this.colPermissions.Width = 129;
            // 
            // tpAddNewUser
            // 
            this.tpAddNewUser.Controls.Add(this.gbPermissions);
            this.tpAddNewUser.Controls.Add(this.lblInputProgress);
            this.tpAddNewUser.Controls.Add(this.progressBar1);
            this.tpAddNewUser.Controls.Add(this.btnAddNewUser);
            this.tpAddNewUser.Controls.Add(this.panel8);
            this.tpAddNewUser.Controls.Add(this.label8);
            this.tpAddNewUser.Controls.Add(this.txtEmail);
            this.tpAddNewUser.Controls.Add(this.panel7);
            this.tpAddNewUser.Controls.Add(this.label7);
            this.tpAddNewUser.Controls.Add(this.txtPhone);
            this.tpAddNewUser.Controls.Add(this.panel6);
            this.tpAddNewUser.Controls.Add(this.panel5);
            this.tpAddNewUser.Controls.Add(this.label6);
            this.tpAddNewUser.Controls.Add(this.txtFirstName);
            this.tpAddNewUser.Controls.Add(this.label5);
            this.tpAddNewUser.Controls.Add(this.txtLastName);
            this.tpAddNewUser.Controls.Add(this.panel4);
            this.tpAddNewUser.Controls.Add(this.label4);
            this.tpAddNewUser.Controls.Add(this.txtPassword);
            this.tpAddNewUser.Controls.Add(this.panel3);
            this.tpAddNewUser.Controls.Add(this.label3);
            this.tpAddNewUser.Controls.Add(this.txtUsername);
            this.tpAddNewUser.Location = new System.Drawing.Point(4, 34);
            this.tpAddNewUser.Name = "tpAddNewUser";
            this.tpAddNewUser.Size = new System.Drawing.Size(915, 539);
            this.tpAddNewUser.TabIndex = 1;
            this.tpAddNewUser.Text = "Add New User";
            this.tpAddNewUser.UseVisualStyleBackColor = true;
            // 
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.chkManageUsers);
            this.gbPermissions.Controls.Add(this.chkClientsTransactions);
            this.gbPermissions.Controls.Add(this.chkManageClients);
            this.gbPermissions.Controls.Add(this.rbNo);
            this.gbPermissions.Controls.Add(this.rbYes);
            this.gbPermissions.Controls.Add(this.label9);
            this.gbPermissions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbPermissions.Location = new System.Drawing.Point(44, 377);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(453, 157);
            this.gbPermissions.TabIndex = 27;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Permissions";
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Enabled = false;
            this.chkManageUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageUsers.ForeColor = System.Drawing.Color.DarkRed;
            this.chkManageUsers.Location = new System.Drawing.Point(322, 127);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(127, 24);
            this.chkManageUsers.TabIndex = 33;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            this.chkManageUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetNewUserPermissions);
            // 
            // chkClientsTransactions
            // 
            this.chkClientsTransactions.AutoSize = true;
            this.chkClientsTransactions.Enabled = false;
            this.chkClientsTransactions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClientsTransactions.ForeColor = System.Drawing.Color.DarkRed;
            this.chkClientsTransactions.Location = new System.Drawing.Point(150, 127);
            this.chkClientsTransactions.Name = "chkClientsTransactions";
            this.chkClientsTransactions.Size = new System.Drawing.Size(167, 24);
            this.chkClientsTransactions.TabIndex = 32;
            this.chkClientsTransactions.Text = "Clients Transactions";
            this.chkClientsTransactions.UseVisualStyleBackColor = true;
            this.chkClientsTransactions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetNewUserPermissions);
            // 
            // chkManageClients
            // 
            this.chkManageClients.AutoSize = true;
            this.chkManageClients.Enabled = false;
            this.chkManageClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageClients.ForeColor = System.Drawing.Color.DarkRed;
            this.chkManageClients.Location = new System.Drawing.Point(9, 127);
            this.chkManageClients.Name = "chkManageClients";
            this.chkManageClients.Size = new System.Drawing.Size(135, 24);
            this.chkManageClients.TabIndex = 31;
            this.chkManageClients.Text = "Manage Clients";
            this.chkManageClients.UseVisualStyleBackColor = true;
            this.chkManageClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetNewUserPermissions);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.ForeColor = System.Drawing.Color.DarkRed;
            this.rbNo.Location = new System.Drawing.Point(244, 67);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(57, 29);
            this.rbNo.TabIndex = 30;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetNewUserPermissions);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(149, 67);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(58, 29);
            this.rbYes.TabIndex = 29;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetNewUserPermissions);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(144, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Give Full Access?";
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
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewUser.FlatAppearance.BorderSize = 2;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Location = new System.Drawing.Point(569, 429);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(200, 44);
            this.btnAddNewUser.TabIndex = 24;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddNewUser_Click);
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
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
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
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
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
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
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
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPassword.Location = new System.Drawing.Point(297, 60);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 26);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
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
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "User name";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUsername.Location = new System.Drawing.Point(44, 60);
            this.txtUsername.MaxLength = 10;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 26);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // tpUpdateUser
            // 
            this.tpUpdateUser.Controls.Add(this.gbUpdtPermissions);
            this.tpUpdateUser.Controls.Add(this.cbUpdtUsernames);
            this.tpUpdateUser.Controls.Add(this.btnUpdateUser);
            this.tpUpdateUser.Controls.Add(this.panel9);
            this.tpUpdateUser.Controls.Add(this.label11);
            this.tpUpdateUser.Controls.Add(this.txtUpdtEmail);
            this.tpUpdateUser.Controls.Add(this.panel10);
            this.tpUpdateUser.Controls.Add(this.label12);
            this.tpUpdateUser.Controls.Add(this.txtUpdtPhone);
            this.tpUpdateUser.Controls.Add(this.panel11);
            this.tpUpdateUser.Controls.Add(this.panel12);
            this.tpUpdateUser.Controls.Add(this.label13);
            this.tpUpdateUser.Controls.Add(this.txtUpdtFirstName);
            this.tpUpdateUser.Controls.Add(this.label14);
            this.tpUpdateUser.Controls.Add(this.txtUpdtLastName);
            this.tpUpdateUser.Controls.Add(this.panel13);
            this.tpUpdateUser.Controls.Add(this.label15);
            this.tpUpdateUser.Controls.Add(this.txtUpdtPassword);
            this.tpUpdateUser.Controls.Add(this.label16);
            this.tpUpdateUser.Location = new System.Drawing.Point(4, 34);
            this.tpUpdateUser.Name = "tpUpdateUser";
            this.tpUpdateUser.Size = new System.Drawing.Size(915, 539);
            this.tpUpdateUser.TabIndex = 2;
            this.tpUpdateUser.Text = "Update User";
            this.tpUpdateUser.UseVisualStyleBackColor = true;
            // 
            // gbUpdtPermissions
            // 
            this.gbUpdtPermissions.Controls.Add(this.chkUpdtManageUsers);
            this.gbUpdtPermissions.Controls.Add(this.chkUpdtClientsTransactions);
            this.gbUpdtPermissions.Controls.Add(this.chkUpdtManageClients);
            this.gbUpdtPermissions.Controls.Add(this.rdUpdtNo);
            this.gbUpdtPermissions.Controls.Add(this.rbUpdtYes);
            this.gbUpdtPermissions.Controls.Add(this.label10);
            this.gbUpdtPermissions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdtPermissions.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbUpdtPermissions.Location = new System.Drawing.Point(43, 377);
            this.gbUpdtPermissions.Name = "gbUpdtPermissions";
            this.gbUpdtPermissions.Size = new System.Drawing.Size(453, 157);
            this.gbUpdtPermissions.TabIndex = 47;
            this.gbUpdtPermissions.TabStop = false;
            this.gbUpdtPermissions.Text = "Permissions";
            // 
            // chkUpdtManageUsers
            // 
            this.chkUpdtManageUsers.AutoSize = true;
            this.chkUpdtManageUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdtManageUsers.ForeColor = System.Drawing.Color.DarkRed;
            this.chkUpdtManageUsers.Location = new System.Drawing.Point(322, 127);
            this.chkUpdtManageUsers.Name = "chkUpdtManageUsers";
            this.chkUpdtManageUsers.Size = new System.Drawing.Size(127, 24);
            this.chkUpdtManageUsers.TabIndex = 33;
            this.chkUpdtManageUsers.Text = "Manage Users";
            this.chkUpdtManageUsers.UseVisualStyleBackColor = true;
            this.chkUpdtManageUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetUpdatedUserPermissions);
            // 
            // chkUpdtClientsTransactions
            // 
            this.chkUpdtClientsTransactions.AutoSize = true;
            this.chkUpdtClientsTransactions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdtClientsTransactions.ForeColor = System.Drawing.Color.DarkRed;
            this.chkUpdtClientsTransactions.Location = new System.Drawing.Point(150, 127);
            this.chkUpdtClientsTransactions.Name = "chkUpdtClientsTransactions";
            this.chkUpdtClientsTransactions.Size = new System.Drawing.Size(167, 24);
            this.chkUpdtClientsTransactions.TabIndex = 32;
            this.chkUpdtClientsTransactions.Text = "Clients Transactions";
            this.chkUpdtClientsTransactions.UseVisualStyleBackColor = true;
            this.chkUpdtClientsTransactions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetUpdatedUserPermissions);
            // 
            // chkUpdtManageClients
            // 
            this.chkUpdtManageClients.AutoSize = true;
            this.chkUpdtManageClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdtManageClients.ForeColor = System.Drawing.Color.DarkRed;
            this.chkUpdtManageClients.Location = new System.Drawing.Point(9, 127);
            this.chkUpdtManageClients.Name = "chkUpdtManageClients";
            this.chkUpdtManageClients.Size = new System.Drawing.Size(135, 24);
            this.chkUpdtManageClients.TabIndex = 31;
            this.chkUpdtManageClients.Text = "Manage Clients";
            this.chkUpdtManageClients.UseVisualStyleBackColor = true;
            this.chkUpdtManageClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetUpdatedUserPermissions);
            // 
            // rdUpdtNo
            // 
            this.rdUpdtNo.AutoSize = true;
            this.rdUpdtNo.ForeColor = System.Drawing.Color.DarkRed;
            this.rdUpdtNo.Location = new System.Drawing.Point(244, 67);
            this.rdUpdtNo.Name = "rdUpdtNo";
            this.rdUpdtNo.Size = new System.Drawing.Size(57, 29);
            this.rdUpdtNo.TabIndex = 30;
            this.rdUpdtNo.TabStop = true;
            this.rdUpdtNo.Text = "No";
            this.rdUpdtNo.UseVisualStyleBackColor = true;
            this.rdUpdtNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetUpdatedUserPermissions);
            // 
            // rbUpdtYes
            // 
            this.rbUpdtYes.AutoSize = true;
            this.rbUpdtYes.Location = new System.Drawing.Point(149, 67);
            this.rbUpdtYes.Name = "rbUpdtYes";
            this.rbUpdtYes.Size = new System.Drawing.Size(58, 29);
            this.rbUpdtYes.TabIndex = 29;
            this.rbUpdtYes.TabStop = true;
            this.rbUpdtYes.Text = "Yes";
            this.rbUpdtYes.UseVisualStyleBackColor = true;
            this.rbUpdtYes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetUpdatedUserPermissions);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(144, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Give Full Access?";
            // 
            // cbUpdtUsernames
            // 
            this.cbUpdtUsernames.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbUpdtUsernames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdtUsernames.ForeColor = System.Drawing.Color.White;
            this.cbUpdtUsernames.FormattingEnabled = true;
            this.cbUpdtUsernames.Location = new System.Drawing.Point(43, 56);
            this.cbUpdtUsernames.Name = "cbUpdtUsernames";
            this.cbUpdtUsernames.Size = new System.Drawing.Size(200, 33);
            this.cbUpdtUsernames.TabIndex = 46;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateUser.FlatAppearance.BorderSize = 2;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Location = new System.Drawing.Point(571, 431);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(200, 44);
            this.btnUpdateUser.TabIndex = 45;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdateUser_Click);
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
            this.txtUpdtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
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
            this.label15.Size = new System.Drawing.Size(97, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Password";
            // 
            // txtUpdtPassword
            // 
            this.txtUpdtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdtPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUpdtPassword.Location = new System.Drawing.Point(296, 59);
            this.txtUpdtPassword.MaxLength = 10;
            this.txtUpdtPassword.Multiline = true;
            this.txtUpdtPassword.Name = "txtUpdtPassword";
            this.txtUpdtPassword.Size = new System.Drawing.Size(200, 26);
            this.txtUpdtPassword.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Location = new System.Drawing.Point(38, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "User name";
            // 
            // tpDeleteUser
            // 
            this.tpDeleteUser.Controls.Add(this.btnDeleteUser);
            this.tpDeleteUser.Controls.Add(this.pictureBox2);
            this.tpDeleteUser.Controls.Add(this.label18);
            this.tpDeleteUser.Controls.Add(this.panel14);
            this.tpDeleteUser.Controls.Add(this.label17);
            this.tpDeleteUser.Controls.Add(this.txtDltUsername);
            this.tpDeleteUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDeleteUser.Location = new System.Drawing.Point(4, 34);
            this.tpDeleteUser.Name = "tpDeleteUser";
            this.tpDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteUser.Size = new System.Drawing.Size(915, 539);
            this.tpDeleteUser.TabIndex = 3;
            this.tpDeleteUser.Text = "Delete User";
            this.tpDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteUser.FlatAppearance.BorderSize = 2;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Location = new System.Drawing.Point(196, 247);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(374, 44);
            this.btnDeleteUser.TabIndex = 46;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDeleteUser_Click);
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
            this.label18.Size = new System.Drawing.Size(567, 60);
            this.label18.TabIndex = 12;
            this.label18.Text = "NOTE: This action is permanent – once a user is deleted, \r\ntheir data cannot be r" +
    "ecovered.";
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
            this.label17.Size = new System.Drawing.Size(356, 37);
            this.label17.TabIndex = 10;
            this.label17.Text = "Enter Username To Delete:";
            // 
            // txtDltUsername
            // 
            this.txtDltUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDltUsername.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDltUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtDltUsername.Location = new System.Drawing.Point(196, 173);
            this.txtDltUsername.MaxLength = 10;
            this.txtDltUsername.Multiline = true;
            this.txtDltUsername.Name = "txtDltUsername";
            this.txtDltUsername.Size = new System.Drawing.Size(384, 39);
            this.txtDltUsername.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManageUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 589);
            this.Controls.Add(this.tcClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 628);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1285, 628);
            this.Name = "ManageUsersScreen";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.ManageUsersScreen_Load);
            this.Controls.SetChildIndex(this.tcClients, 0);
            this.tcClients.ResumeLayout(false);
            this.tpShowUsers.ResumeLayout(false);
            this.tpShowUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpAddNewUser.ResumeLayout(false);
            this.tpAddNewUser.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.tpUpdateUser.ResumeLayout(false);
            this.tpUpdateUser.PerformLayout();
            this.gbUpdtPermissions.ResumeLayout(false);
            this.gbUpdtPermissions.PerformLayout();
            this.tpDeleteUser.ResumeLayout(false);
            this.tpDeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClients;
        private System.Windows.Forms.TabPage tpShowUsers;
        private System.Windows.Forms.PictureBox pbGreenSign;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.Label lblNumberOfUsers;
        private System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.TabPage tpAddNewUser;
        private System.Windows.Forms.Label lblInputProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TabPage tpUpdateUser;
        private System.Windows.Forms.ComboBox cbUpdtUsernames;
        private System.Windows.Forms.Button btnUpdateUser;
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
        private System.Windows.Forms.TextBox txtUpdtPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tpDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDltUsername;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colPermissions;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkClientsTransactions;
        private System.Windows.Forms.CheckBox chkManageClients;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.GroupBox gbUpdtPermissions;
        private System.Windows.Forms.CheckBox chkUpdtManageUsers;
        private System.Windows.Forms.CheckBox chkUpdtClientsTransactions;
        private System.Windows.Forms.CheckBox chkUpdtManageClients;
        private System.Windows.Forms.RadioButton rdUpdtNo;
        private System.Windows.Forms.RadioButton rbUpdtYes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}