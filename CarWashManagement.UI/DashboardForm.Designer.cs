namespace CarWashManagement.UI
{
    partial class DashboardForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyYearlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.washEntryPanel = new System.Windows.Forms.Panel();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.chkWashStatus = new System.Windows.Forms.CheckBox();
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.txtServiceEmpShare = new System.Windows.Forms.TextBox();
            this.lblServiceEmpShare = new System.Windows.Forms.Label();
            this.txtServiceOwnerShare = new System.Windows.Forms.TextBox();
            this.lblServiceOwnerShare = new System.Windows.Forms.Label();
            this.txtTotalServiceFee = new System.Windows.Forms.TextBox();
            this.lblTotalServiceFee = new System.Windows.Forms.Label();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.lblAdditionalServices = new System.Windows.Forms.Label();
            this.txtEmployeeShare = new System.Windows.Forms.TextBox();
            this.lblEmployeeShare = new System.Windows.Forms.Label();
            this.txtOwnerShare = new System.Windows.Forms.TextBox();
            this.lblOwnerShare = new System.Windows.Forms.Label();
            this.txtBaseFee = new System.Windows.Forms.TextBox();
            this.lblBaseFee = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.todaysEntriesPanel = new System.Windows.Forms.Panel();
            this.lsvTodayEntries = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.togglePaidStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleWashStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySummaryPanel = new System.Windows.Forms.Panel();
            this.txtSummaryMostWashedVehicle = new System.Windows.Forms.TextBox();
            this.lblSummaryMostWashedVehicle = new System.Windows.Forms.Label();
            this.txtSummaryTotalWashes = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalWashes = new System.Windows.Forms.Label();
            this.txtSummaryTotalEmpShare = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalEmpShare = new System.Windows.Forms.Label();
            this.txtSummaryTotalOwnerShare = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalOwnerShare = new System.Windows.Forms.Label();
            this.txtSummaryTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalRevenue = new System.Windows.Forms.Label();
            this.lblDailySummary = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.washEntryPanel.SuspendLayout();
            this.todaysEntriesPanel.SuspendLayout();
            this.lsvContextMenu.SuspendLayout();
            this.dailySummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.btnChangePassword);
            this.headerPanel.Controls.Add(this.logoutButton);
            this.headerPanel.Controls.Add(this.welcomeLabel);
            this.headerPanel.Controls.Add(this.mainMenu);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(785, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mainMenu.ForeColor = System.Drawing.Color.White;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(785, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.manageServicesToolStripMenuItem,
            this.manageExpensesToolStripMenuItem,
            this.monthlyYearlyReportToolStripMenuItem});
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(39, 24);
            this.adminMenuItem.Text = "•••";
            this.adminMenuItem.Visible = false;
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.ManageUsers_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            this.manageVehiclesToolStripMenuItem.Click += new System.EventHandler(this.ManageVehicles_Click);
            // 
            // manageServicesToolStripMenuItem
            // 
            this.manageServicesToolStripMenuItem.Name = "manageServicesToolStripMenuItem";
            this.manageServicesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.manageServicesToolStripMenuItem.Text = "Manage Services";
            this.manageServicesToolStripMenuItem.Click += new System.EventHandler(this.ManageServices_Click);
            // 
            // manageExpensesToolStripMenuItem
            // 
            this.manageExpensesToolStripMenuItem.Name = "manageExpensesToolStripMenuItem";
            this.manageExpensesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.manageExpensesToolStripMenuItem.Text = "Manage Expenses";
            this.manageExpensesToolStripMenuItem.Click += new System.EventHandler(this.ManageExpenses_Click);
            // 
            // monthlyYearlyReportToolStripMenuItem
            // 
            this.monthlyYearlyReportToolStripMenuItem.Name = "monthlyYearlyReportToolStripMenuItem";
            this.monthlyYearlyReportToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.monthlyYearlyReportToolStripMenuItem.Text = "Monthly/Yearly Report";
            this.monthlyYearlyReportToolStripMenuItem.Click += new System.EventHandler(this.ShowMonthlyReport_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChangePassword.Location = new System.Drawing.Point(535, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(125, 30);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.logoutButton.Location = new System.Drawing.Point(665, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 30);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.White;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.welcomeLabel.Location = new System.Drawing.Point(10, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(78, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome,";
            // 
            // washEntryPanel
            // 
            this.washEntryPanel.BackColor = System.Drawing.Color.White;
            this.washEntryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.washEntryPanel.Controls.Add(this.btnAddTransaction);
            this.washEntryPanel.Controls.Add(this.txtTotalAmount);
            this.washEntryPanel.Controls.Add(this.lblTotalAmount);
            this.washEntryPanel.Controls.Add(this.cmbDiscount);
            this.washEntryPanel.Controls.Add(this.lblDiscount);
            this.washEntryPanel.Controls.Add(this.chkWashStatus);
            this.washEntryPanel.Controls.Add(this.chkIsPaid);
            this.washEntryPanel.Controls.Add(this.txtServiceEmpShare);
            this.washEntryPanel.Controls.Add(this.lblServiceEmpShare);
            this.washEntryPanel.Controls.Add(this.txtServiceOwnerShare);
            this.washEntryPanel.Controls.Add(this.lblServiceOwnerShare);
            this.washEntryPanel.Controls.Add(this.txtTotalServiceFee);
            this.washEntryPanel.Controls.Add(this.lblTotalServiceFee);
            this.washEntryPanel.Controls.Add(this.servicePanel);
            this.washEntryPanel.Controls.Add(this.lblAdditionalServices);
            this.washEntryPanel.Controls.Add(this.txtEmployeeShare);
            this.washEntryPanel.Controls.Add(this.lblEmployeeShare);
            this.washEntryPanel.Controls.Add(this.txtOwnerShare);
            this.washEntryPanel.Controls.Add(this.lblOwnerShare);
            this.washEntryPanel.Controls.Add(this.txtBaseFee);
            this.washEntryPanel.Controls.Add(this.lblBaseFee);
            this.washEntryPanel.Controls.Add(this.cmbVehicleType);
            this.washEntryPanel.Controls.Add(this.lblVehicleType);
            this.washEntryPanel.Controls.Add(this.txtEmployeeName);
            this.washEntryPanel.Controls.Add(this.lblEmployee);
            this.washEntryPanel.Location = new System.Drawing.Point(10, 60);
            this.washEntryPanel.Name = "washEntryPanel";
            this.washEntryPanel.Size = new System.Drawing.Size(300, 590);
            this.washEntryPanel.TabIndex = 1;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(10, 548);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(270, 30);
            this.btnAddTransaction.TabIndex = 25;
            this.btnAddTransaction.Text = "Add Entry";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Location = new System.Drawing.Point(120, 510);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(160, 23);
            this.txtTotalAmount.TabIndex = 24;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(10, 513);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(103, 19);
            this.lblTotalAmount.TabIndex = 23;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "N/A",
            "PWD",
            "Senior"});
            this.cmbDiscount.Location = new System.Drawing.Point(220, 448);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(60, 23);
            this.cmbDiscount.TabIndex = 22;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(160, 448);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(57, 15);
            this.lblDiscount.TabIndex = 21;
            this.lblDiscount.Text = "Discount:";
            // 
            // chkWashStatus
            // 
            this.chkWashStatus.AutoSize = true;
            this.chkWashStatus.Location = new System.Drawing.Point(10, 478);
            this.chkWashStatus.Name = "chkWashStatus";
            this.chkWashStatus.Size = new System.Drawing.Size(129, 19);
            this.chkWashStatus.TabIndex = 20;
            this.chkWashStatus.Text = "Mark as Completed";
            this.chkWashStatus.UseVisualStyleBackColor = true;
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Location = new System.Drawing.Point(10, 448);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(120, 19);
            this.chkIsPaid.TabIndex = 19;
            this.chkIsPaid.Text = "Paid by Employee";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtServiceEmpShare
            // 
            this.txtServiceEmpShare.BackColor = System.Drawing.Color.White;
            this.txtServiceEmpShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceEmpShare.Location = new System.Drawing.Point(190, 418);
            this.txtServiceEmpShare.Name = "txtServiceEmpShare";
            this.txtServiceEmpShare.ReadOnly = true;
            this.txtServiceEmpShare.Size = new System.Drawing.Size(80, 23);
            this.txtServiceEmpShare.TabIndex = 18;
            this.txtServiceEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceEmpShare
            // 
            this.lblServiceEmpShare.AutoSize = true;
            this.lblServiceEmpShare.Location = new System.Drawing.Point(190, 398);
            this.lblServiceEmpShare.Name = "lblServiceEmpShare";
            this.lblServiceEmpShare.Size = new System.Drawing.Size(94, 15);
            this.lblServiceEmpShare.TabIndex = 17;
            this.lblServiceEmpShare.Text = "Employee Share:";
            // 
            // txtServiceOwnerShare
            // 
            this.txtServiceOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtServiceOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceOwnerShare.Location = new System.Drawing.Point(100, 418);
            this.txtServiceOwnerShare.Name = "txtServiceOwnerShare";
            this.txtServiceOwnerShare.ReadOnly = true;
            this.txtServiceOwnerShare.Size = new System.Drawing.Size(80, 23);
            this.txtServiceOwnerShare.TabIndex = 16;
            this.txtServiceOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceOwnerShare
            // 
            this.lblServiceOwnerShare.AutoSize = true;
            this.lblServiceOwnerShare.Location = new System.Drawing.Point(100, 398);
            this.lblServiceOwnerShare.Name = "lblServiceOwnerShare";
            this.lblServiceOwnerShare.Size = new System.Drawing.Size(77, 15);
            this.lblServiceOwnerShare.TabIndex = 15;
            this.lblServiceOwnerShare.Text = "Owner Share:";
            // 
            // txtTotalServiceFee
            // 
            this.txtTotalServiceFee.BackColor = System.Drawing.Color.White;
            this.txtTotalServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalServiceFee.Location = new System.Drawing.Point(10, 418);
            this.txtTotalServiceFee.Name = "txtTotalServiceFee";
            this.txtTotalServiceFee.ReadOnly = true;
            this.txtTotalServiceFee.Size = new System.Drawing.Size(80, 23);
            this.txtTotalServiceFee.TabIndex = 14;
            this.txtTotalServiceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalServiceFee
            // 
            this.lblTotalServiceFee.AutoSize = true;
            this.lblTotalServiceFee.Location = new System.Drawing.Point(10, 398);
            this.lblTotalServiceFee.Name = "lblTotalServiceFee";
            this.lblTotalServiceFee.Size = new System.Drawing.Size(78, 15);
            this.lblTotalServiceFee.TabIndex = 13;
            this.lblTotalServiceFee.Text = "Service/s Fee:";
            // 
            // servicePanel
            // 
            this.servicePanel.AutoScroll = true;
            this.servicePanel.Location = new System.Drawing.Point(10, 178);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(280, 200);
            this.servicePanel.TabIndex = 12;
            // 
            // lblAdditionalServices
            // 
            this.lblAdditionalServices.AutoSize = true;
            this.lblAdditionalServices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAdditionalServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAdditionalServices.Location = new System.Drawing.Point(10, 155);
            this.lblAdditionalServices.Name = "lblAdditionalServices";
            this.lblAdditionalServices.Size = new System.Drawing.Size(147, 20);
            this.lblAdditionalServices.TabIndex = 11;
            this.lblAdditionalServices.Text = "Additional Services:";
            // 
            // txtEmployeeShare
            // 
            this.txtEmployeeShare.BackColor = System.Drawing.Color.White;
            this.txtEmployeeShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeShare.Location = new System.Drawing.Point(190, 125);
            this.txtEmployeeShare.Name = "txtEmployeeShare";
            this.txtEmployeeShare.ReadOnly = true;
            this.txtEmployeeShare.Size = new System.Drawing.Size(80, 23);
            this.txtEmployeeShare.TabIndex = 10;
            this.txtEmployeeShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEmployeeShare
            // 
            this.lblEmployeeShare.AutoSize = true;
            this.lblEmployeeShare.Location = new System.Drawing.Point(190, 105);
            this.lblEmployeeShare.Name = "lblEmployeeShare";
            this.lblEmployeeShare.Size = new System.Drawing.Size(94, 15);
            this.lblEmployeeShare.TabIndex = 9;
            this.lblEmployeeShare.Text = "Employee Share:";
            // 
            // txtOwnerShare
            // 
            this.txtOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOwnerShare.Location = new System.Drawing.Point(100, 125);
            this.txtOwnerShare.Name = "txtOwnerShare";
            this.txtOwnerShare.ReadOnly = true;
            this.txtOwnerShare.Size = new System.Drawing.Size(80, 23);
            this.txtOwnerShare.TabIndex = 8;
            this.txtOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOwnerShare
            // 
            this.lblOwnerShare.AutoSize = true;
            this.lblOwnerShare.Location = new System.Drawing.Point(100, 105);
            this.lblOwnerShare.Name = "lblOwnerShare";
            this.lblOwnerShare.Size = new System.Drawing.Size(77, 15);
            this.lblOwnerShare.TabIndex = 7;
            this.lblOwnerShare.Text = "Owner Share:";
            // 
            // txtBaseFee
            // 
            this.txtBaseFee.BackColor = System.Drawing.Color.White;
            this.txtBaseFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaseFee.Location = new System.Drawing.Point(10, 125);
            this.txtBaseFee.Name = "txtBaseFee";
            this.txtBaseFee.ReadOnly = true;
            this.txtBaseFee.Size = new System.Drawing.Size(80, 23);
            this.txtBaseFee.TabIndex = 6;
            this.txtBaseFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBaseFee
            // 
            this.lblBaseFee.AutoSize = true;
            this.lblBaseFee.Location = new System.Drawing.Point(10, 105);
            this.lblBaseFee.Name = "lblBaseFee";
            this.lblBaseFee.Size = new System.Drawing.Size(55, 15);
            this.lblBaseFee.TabIndex = 5;
            this.lblBaseFee.Text = "Base Fee:";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(110, 47);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(170, 23);
            this.cmbVehicleType.TabIndex = 4;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(10, 50);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(74, 15);
            this.lblVehicleType.TabIndex = 3;
            this.lblVehicleType.Text = "Vehicle Type:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(110, 12);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(170, 23);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(10, 15);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(97, 15);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee Name:";
            // 
            // todaysEntriesPanel
            // 
            this.todaysEntriesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todaysEntriesPanel.Controls.Add(this.lsvTodayEntries);
            this.todaysEntriesPanel.Location = new System.Drawing.Point(320, 60);
            this.todaysEntriesPanel.Name = "todaysEntriesPanel";
            this.todaysEntriesPanel.Size = new System.Drawing.Size(455, 380);
            this.todaysEntriesPanel.TabIndex = 2;
            // 
            // lsvTodayEntries
            // 
            this.lsvTodayEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvTodayEntries.ContextMenuStrip = this.lsvContextMenu;
            this.lsvTodayEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvTodayEntries.FullRowSelect = true;
            this.lsvTodayEntries.GridLines = true;
            this.lsvTodayEntries.HideSelection = false;
            this.lsvTodayEntries.Location = new System.Drawing.Point(0, 0);
            this.lsvTodayEntries.Name = "lsvTodayEntries";
            this.lsvTodayEntries.Size = new System.Drawing.Size(453, 378);
            this.lsvTodayEntries.TabIndex = 0;
            this.lsvTodayEntries.UseCompatibleStateImageBehavior = false;
            this.lsvTodayEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vehicle";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Employee";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Paid";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Wash Status";
            this.columnHeader6.Width = 85;
            // 
            // lsvContextMenu
            // 
            this.lsvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.togglePaidStatusToolStripMenuItem,
            this.toggleWashStatusToolStripMenuItem});
            this.lsvContextMenu.Name = "lsvContextMenu";
            this.lsvContextMenu.Size = new System.Drawing.Size(191, 48);
            // 
            // togglePaidStatusToolStripMenuItem
            // 
            this.togglePaidStatusToolStripMenuItem.Name = "togglePaidStatusToolStripMenuItem";
            this.togglePaidStatusToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.togglePaidStatusToolStripMenuItem.Text = "Toggle Paid Status";
            this.togglePaidStatusToolStripMenuItem.Click += new System.EventHandler(this.TogglePaidStatus_Click);
            // 
            // toggleWashStatusToolStripMenuItem
            // 
            this.toggleWashStatusToolStripMenuItem.Name = "toggleWashStatusToolStripMenuItem";
            this.toggleWashStatusToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.toggleWashStatusToolStripMenuItem.Text = "Toggle Wash Status";
            this.toggleWashStatusToolStripMenuItem.Click += new System.EventHandler(this.ToggleWashStatus_Click);
            // 
            // dailySummaryPanel
            // 
            this.dailySummaryPanel.BackColor = System.Drawing.Color.White;
            this.dailySummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailySummaryPanel.Controls.Add(this.txtSummaryMostWashedVehicle);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryMostWashedVehicle);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalWashes);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalWashes);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalEmpShare);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalEmpShare);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalOwnerShare);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalOwnerShare);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalRevenue);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalRevenue);
            this.dailySummaryPanel.Controls.Add(this.lblDailySummary);
            this.dailySummaryPanel.Location = new System.Drawing.Point(320, 450);
            this.dailySummaryPanel.Name = "dailySummaryPanel";
            this.dailySummaryPanel.Size = new System.Drawing.Size(455, 200);
            this.dailySummaryPanel.TabIndex = 3;
            // 
            // txtSummaryMostWashedVehicle
            // 
            this.txtSummaryMostWashedVehicle.BackColor = System.Drawing.Color.White;
            this.txtSummaryMostWashedVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryMostWashedVehicle.Location = new System.Drawing.Point(240, 160);
            this.txtSummaryMostWashedVehicle.Name = "txtSummaryMostWashedVehicle";
            this.txtSummaryMostWashedVehicle.ReadOnly = true;
            this.txtSummaryMostWashedVehicle.Size = new System.Drawing.Size(180, 23);
            this.txtSummaryMostWashedVehicle.TabIndex = 10;
            this.txtSummaryMostWashedVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryMostWashedVehicle
            // 
            this.lblSummaryMostWashedVehicle.AutoSize = true;
            this.lblSummaryMostWashedVehicle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryMostWashedVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryMostWashedVehicle.Location = new System.Drawing.Point(240, 140);
            this.lblSummaryMostWashedVehicle.Name = "lblSummaryMostWashedVehicle";
            this.lblSummaryMostWashedVehicle.Size = new System.Drawing.Size(128, 15);
            this.lblSummaryMostWashedVehicle.TabIndex = 9;
            this.lblSummaryMostWashedVehicle.Text = "Most Washed Vehicle:";
            // 
            // txtSummaryTotalWashes
            // 
            this.txtSummaryTotalWashes.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalWashes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalWashes.Location = new System.Drawing.Point(15, 160);
            this.txtSummaryTotalWashes.Name = "txtSummaryTotalWashes";
            this.txtSummaryTotalWashes.ReadOnly = true;
            this.txtSummaryTotalWashes.Size = new System.Drawing.Size(180, 23);
            this.txtSummaryTotalWashes.TabIndex = 8;
            this.txtSummaryTotalWashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalWashes
            // 
            this.lblSummaryTotalWashes.AutoSize = true;
            this.lblSummaryTotalWashes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalWashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalWashes.Location = new System.Drawing.Point(15, 140);
            this.lblSummaryTotalWashes.Name = "lblSummaryTotalWashes";
            this.lblSummaryTotalWashes.Size = new System.Drawing.Size(82, 15);
            this.lblSummaryTotalWashes.TabIndex = 7;
            this.lblSummaryTotalWashes.Text = "Total Washes:";
            // 
            // txtSummaryTotalEmpShare
            // 
            this.txtSummaryTotalEmpShare.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalEmpShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalEmpShare.Location = new System.Drawing.Point(240, 110);
            this.txtSummaryTotalEmpShare.Name = "txtSummaryTotalEmpShare";
            this.txtSummaryTotalEmpShare.ReadOnly = true;
            this.txtSummaryTotalEmpShare.Size = new System.Drawing.Size(180, 23);
            this.txtSummaryTotalEmpShare.TabIndex = 6;
            this.txtSummaryTotalEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalEmpShare
            // 
            this.lblSummaryTotalEmpShare.AutoSize = true;
            this.lblSummaryTotalEmpShare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalEmpShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalEmpShare.Location = new System.Drawing.Point(240, 90);
            this.lblSummaryTotalEmpShare.Name = "lblSummaryTotalEmpShare";
            this.lblSummaryTotalEmpShare.Size = new System.Drawing.Size(129, 15);
            this.lblSummaryTotalEmpShare.TabIndex = 5;
            this.lblSummaryTotalEmpShare.Text = "Total Employee Share:";
            // 
            // txtSummaryTotalOwnerShare
            // 
            this.txtSummaryTotalOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalOwnerShare.Location = new System.Drawing.Point(15, 110);
            this.txtSummaryTotalOwnerShare.Name = "txtSummaryTotalOwnerShare";
            this.txtSummaryTotalOwnerShare.ReadOnly = true;
            this.txtSummaryTotalOwnerShare.Size = new System.Drawing.Size(180, 23);
            this.txtSummaryTotalOwnerShare.TabIndex = 4;
            this.txtSummaryTotalOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalOwnerShare
            // 
            this.lblSummaryTotalOwnerShare.AutoSize = true;
            this.lblSummaryTotalOwnerShare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalOwnerShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalOwnerShare.Location = new System.Drawing.Point(15, 90);
            this.lblSummaryTotalOwnerShare.Name = "lblSummaryTotalOwnerShare";
            this.lblSummaryTotalOwnerShare.Size = new System.Drawing.Size(113, 15);
            this.lblSummaryTotalOwnerShare.TabIndex = 3;
            this.lblSummaryTotalOwnerShare.Text = "Total Owner Share:";
            // 
            // txtSummaryTotalRevenue
            // 
            this.txtSummaryTotalRevenue.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSummaryTotalRevenue.Location = new System.Drawing.Point(15, 60);
            this.txtSummaryTotalRevenue.Name = "txtSummaryTotalRevenue";
            this.txtSummaryTotalRevenue.ReadOnly = true;
            this.txtSummaryTotalRevenue.Size = new System.Drawing.Size(180, 23);
            this.txtSummaryTotalRevenue.TabIndex = 2;
            this.txtSummaryTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalRevenue
            // 
            this.lblSummaryTotalRevenue.AutoSize = true;
            this.lblSummaryTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalRevenue.Location = new System.Drawing.Point(15, 40);
            this.lblSummaryTotalRevenue.Name = "lblSummaryTotalRevenue";
            this.lblSummaryTotalRevenue.Size = new System.Drawing.Size(90, 15);
            this.lblSummaryTotalRevenue.TabIndex = 1;
            this.lblSummaryTotalRevenue.Text = "Total Revenue:";
            // 
            // lblDailySummary
            // 
            this.lblDailySummary.AutoSize = true;
            this.lblDailySummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDailySummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDailySummary.Location = new System.Drawing.Point(15, 10);
            this.lblDailySummary.Name = "lblDailySummary";
            this.lblDailySummary.Size = new System.Drawing.Size(116, 20);
            this.lblDailySummary.TabIndex = 0;
            this.lblDailySummary.Text = "Daily Summary";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.dailySummaryPanel);
            this.Controls.Add(this.todaysEntriesPanel);
            this.Controls.Add(this.washEntryPanel);
            this.Controls.Add(this.headerPanel);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "DashboardForm";
            this.Text = "Car Wash Management - Daily Dashboard";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.washEntryPanel.ResumeLayout(false);
            this.washEntryPanel.PerformLayout();
            this.todaysEntriesPanel.ResumeLayout(false);
            this.lsvContextMenu.ResumeLayout(false);
            this.dailySummaryPanel.ResumeLayout(false);
            this.dailySummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyYearlyReportToolStripMenuItem;
        private System.Windows.Forms.Panel washEntryPanel;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label lblBaseFee;
        private System.Windows.Forms.TextBox txtBaseFee;
        private System.Windows.Forms.Label lblOwnerShare;
        private System.Windows.Forms.TextBox txtOwnerShare;
        private System.Windows.Forms.Label lblEmployeeShare;
        private System.Windows.Forms.TextBox txtEmployeeShare;
        private System.Windows.Forms.Label lblAdditionalServices;
        private System.Windows.Forms.Panel servicePanel;
        private System.Windows.Forms.Label lblTotalServiceFee;
        private System.Windows.Forms.TextBox txtTotalServiceFee;
        private System.Windows.Forms.Label lblServiceOwnerShare;
        private System.Windows.Forms.TextBox txtServiceOwnerShare;
        private System.Windows.Forms.Label lblServiceEmpShare;
        private System.Windows.Forms.TextBox txtServiceEmpShare;
        private System.Windows.Forms.CheckBox chkIsPaid;
        private System.Windows.Forms.CheckBox chkWashStatus;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Panel todaysEntriesPanel;
        private System.Windows.Forms.ListView lsvTodayEntries;
        private System.Windows.Forms.ContextMenuStrip lsvContextMenu;
        private System.Windows.Forms.ToolStripMenuItem togglePaidStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleWashStatusToolStripMenuItem;
        private System.Windows.Forms.Panel dailySummaryPanel;
        private System.Windows.Forms.Label lblDailySummary;
        private System.Windows.Forms.Label lblSummaryTotalRevenue;
        private System.Windows.Forms.TextBox txtSummaryTotalRevenue;
        private System.Windows.Forms.Label lblSummaryTotalOwnerShare;
        private System.Windows.Forms.TextBox txtSummaryTotalOwnerShare;
        private System.Windows.Forms.Label lblSummaryTotalEmpShare;
        private System.Windows.Forms.TextBox txtSummaryTotalEmpShare;
        private System.Windows.Forms.Label lblSummaryTotalWashes;
        private System.Windows.Forms.TextBox txtSummaryTotalWashes;
        private System.Windows.Forms.Label lblSummaryMostWashedVehicle;
        private System.Windows.Forms.TextBox txtSummaryMostWashedVehicle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}