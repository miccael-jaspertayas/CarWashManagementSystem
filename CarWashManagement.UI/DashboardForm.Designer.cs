using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
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
            this.mainMenu.SuspendLayout();
            this.washEntryPanel.SuspendLayout();
            this.todaysEntriesPanel.SuspendLayout();
            this.lsvContextMenu.SuspendLayout();
            this.dailySummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(811, 17);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 35);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(915, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.manageServicesToolStripMenuItem,
            this.manageExpensesToolStripMenuItem,
            this.monthlyReportToolStripMenuItem});
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(57, 21);
            this.adminMenuItem.Text = "Admin";
            this.adminMenuItem.Visible = false;
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.ManageUsers_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            this.manageVehiclesToolStripMenuItem.Click += new System.EventHandler(this.ManageVehicles_Click);
            // 
            // manageServicesToolStripMenuItem
            // 
            this.manageServicesToolStripMenuItem.Name = "manageServicesToolStripMenuItem";
            this.manageServicesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.manageServicesToolStripMenuItem.Text = "Manage Services";
            this.manageServicesToolStripMenuItem.Click += new System.EventHandler(this.ManageServices_Click);
            // 
            // manageExpensesToolStripMenuItem
            // 
            this.manageExpensesToolStripMenuItem.Name = "manageExpensesToolStripMenuItem";
            this.manageExpensesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.manageExpensesToolStripMenuItem.Text = "Manage Expenses";
            this.manageExpensesToolStripMenuItem.Click += new System.EventHandler(this.ManageExpenses_Click);
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.ShowMonthlyReport_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 33);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(60, 15);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.AutoSize = true;
            this.lnkChangePassword.Location = new System.Drawing.Point(677, 33);
            this.lnkChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(101, 15);
            this.lnkChangePassword.TabIndex = 3;
            this.lnkChangePassword.TabStop = true;
            this.lnkChangePassword.Text = "Change Password";
            this.lnkChangePassword.Click += new System.EventHandler(this.lnkChangePassword_Click);
            // 
            // washEntryPanel
            // 
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
            this.washEntryPanel.Location = new System.Drawing.Point(12, 58);
            this.washEntryPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.washEntryPanel.Name = "washEntryPanel";
            this.washEntryPanel.Size = new System.Drawing.Size(350, 577);
            this.washEntryPanel.TabIndex = 4;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(12, 537);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(315, 29);
            this.btnAddTransaction.TabIndex = 23;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(128, 504);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(198, 20);
            this.txtTotalAmount.TabIndex = 22;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(12, 508);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(86, 13);
            this.lblTotalAmount.TabIndex = 21;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "N/A",
            "PWD",
            "Senior"});
            this.cmbDiscount.Location = new System.Drawing.Point(257, 435);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(69, 23);
            this.cmbDiscount.TabIndex = 20;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(187, 438);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(57, 15);
            this.lblDiscount.TabIndex = 19;
            this.lblDiscount.Text = "Discount:";
            // 
            // chkWashStatus
            // 
            this.chkWashStatus.AutoSize = true;
            this.chkWashStatus.Location = new System.Drawing.Point(12, 464);
            this.chkWashStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkWashStatus.Name = "chkWashStatus";
            this.chkWashStatus.Size = new System.Drawing.Size(129, 19);
            this.chkWashStatus.TabIndex = 18;
            this.chkWashStatus.Text = "Mark as Completed";
            this.chkWashStatus.UseVisualStyleBackColor = true;
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Location = new System.Drawing.Point(12, 438);
            this.chkIsPaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(120, 19);
            this.chkIsPaid.TabIndex = 17;
            this.chkIsPaid.Text = "Paid by Employee";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtServiceEmpShare
            // 
            this.txtServiceEmpShare.Location = new System.Drawing.Point(222, 392);
            this.txtServiceEmpShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServiceEmpShare.Name = "txtServiceEmpShare";
            this.txtServiceEmpShare.ReadOnly = true;
            this.txtServiceEmpShare.Size = new System.Drawing.Size(93, 23);
            this.txtServiceEmpShare.TabIndex = 16;
            this.txtServiceEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceEmpShare
            // 
            this.lblServiceEmpShare.AutoSize = true;
            this.lblServiceEmpShare.Location = new System.Drawing.Point(222, 369);
            this.lblServiceEmpShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceEmpShare.Name = "lblServiceEmpShare";
            this.lblServiceEmpShare.Size = new System.Drawing.Size(94, 15);
            this.lblServiceEmpShare.TabIndex = 15;
            this.lblServiceEmpShare.Text = "Employee Share:";
            // 
            // txtServiceOwnerShare
            // 
            this.txtServiceOwnerShare.Location = new System.Drawing.Point(117, 392);
            this.txtServiceOwnerShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServiceOwnerShare.Name = "txtServiceOwnerShare";
            this.txtServiceOwnerShare.ReadOnly = true;
            this.txtServiceOwnerShare.Size = new System.Drawing.Size(93, 23);
            this.txtServiceOwnerShare.TabIndex = 14;
            this.txtServiceOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceOwnerShare
            // 
            this.lblServiceOwnerShare.AutoSize = true;
            this.lblServiceOwnerShare.Location = new System.Drawing.Point(117, 369);
            this.lblServiceOwnerShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceOwnerShare.Name = "lblServiceOwnerShare";
            this.lblServiceOwnerShare.Size = new System.Drawing.Size(77, 15);
            this.lblServiceOwnerShare.TabIndex = 13;
            this.lblServiceOwnerShare.Text = "Owner Share:";
            // 
            // txtTotalServiceFee
            // 
            this.txtTotalServiceFee.Location = new System.Drawing.Point(12, 392);
            this.txtTotalServiceFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalServiceFee.Name = "txtTotalServiceFee";
            this.txtTotalServiceFee.ReadOnly = true;
            this.txtTotalServiceFee.Size = new System.Drawing.Size(93, 23);
            this.txtTotalServiceFee.TabIndex = 12;
            this.txtTotalServiceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalServiceFee
            // 
            this.lblTotalServiceFee.AutoSize = true;
            this.lblTotalServiceFee.Location = new System.Drawing.Point(12, 369);
            this.lblTotalServiceFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalServiceFee.Name = "lblTotalServiceFee";
            this.lblTotalServiceFee.Size = new System.Drawing.Size(78, 15);
            this.lblTotalServiceFee.TabIndex = 11;
            this.lblTotalServiceFee.Text = "Service/s Fee:";
            // 
            // lblAdditionalServices
            // 
            this.lblAdditionalServices.AutoSize = true;
            this.lblAdditionalServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalServices.Location = new System.Drawing.Point(12, 167);
            this.lblAdditionalServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdditionalServices.Name = "lblAdditionalServices";
            this.lblAdditionalServices.Size = new System.Drawing.Size(120, 13);
            this.lblAdditionalServices.TabIndex = 10;
            this.lblAdditionalServices.Text = "Additional Services:";
            // 
            // txtEmployeeShare
            // 
            this.txtEmployeeShare.Location = new System.Drawing.Point(222, 121);
            this.txtEmployeeShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmployeeShare.Name = "txtEmployeeShare";
            this.txtEmployeeShare.ReadOnly = true;
            this.txtEmployeeShare.Size = new System.Drawing.Size(93, 23);
            this.txtEmployeeShare.TabIndex = 9;
            this.txtEmployeeShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEmployeeShare
            // 
            this.lblEmployeeShare.AutoSize = true;
            this.lblEmployeeShare.Location = new System.Drawing.Point(222, 98);
            this.lblEmployeeShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeShare.Name = "lblEmployeeShare";
            this.lblEmployeeShare.Size = new System.Drawing.Size(94, 15);
            this.lblEmployeeShare.TabIndex = 8;
            this.lblEmployeeShare.Text = "Employee Share:";
            // 
            // txtOwnerShare
            // 
            this.txtOwnerShare.Location = new System.Drawing.Point(117, 121);
            this.txtOwnerShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOwnerShare.Name = "txtOwnerShare";
            this.txtOwnerShare.ReadOnly = true;
            this.txtOwnerShare.Size = new System.Drawing.Size(93, 23);
            this.txtOwnerShare.TabIndex = 7;
            this.txtOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOwnerShare
            // 
            this.lblOwnerShare.AutoSize = true;
            this.lblOwnerShare.Location = new System.Drawing.Point(117, 98);
            this.lblOwnerShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerShare.Name = "lblOwnerShare";
            this.lblOwnerShare.Size = new System.Drawing.Size(77, 15);
            this.lblOwnerShare.TabIndex = 6;
            this.lblOwnerShare.Text = "Owner Share:";
            // 
            // txtBaseFee
            // 
            this.txtBaseFee.Location = new System.Drawing.Point(12, 121);
            this.txtBaseFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBaseFee.Name = "txtBaseFee";
            this.txtBaseFee.ReadOnly = true;
            this.txtBaseFee.Size = new System.Drawing.Size(93, 23);
            this.txtBaseFee.TabIndex = 5;
            this.txtBaseFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBaseFee
            // 
            this.lblBaseFee.AutoSize = true;
            this.lblBaseFee.Location = new System.Drawing.Point(12, 98);
            this.lblBaseFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseFee.Name = "lblBaseFee";
            this.lblBaseFee.Size = new System.Drawing.Size(55, 15);
            this.lblBaseFee.TabIndex = 4;
            this.lblBaseFee.Text = "Base Fee:";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(128, 54);
            this.cmbVehicleType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(198, 23);
            this.cmbVehicleType.TabIndex = 3;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(12, 58);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(74, 15);
            this.lblVehicleType.TabIndex = 2;
            this.lblVehicleType.Text = "Vehicle Type:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(128, 14);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 23);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 17);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(97, 15);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee Name:";
            // 
            // todaysEntriesPanel
            // 
            this.todaysEntriesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todaysEntriesPanel.Controls.Add(this.lsvTodayEntries);
            this.todaysEntriesPanel.Location = new System.Drawing.Point(373, 58);
            this.todaysEntriesPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.todaysEntriesPanel.Name = "todaysEntriesPanel";
            this.todaysEntriesPanel.Size = new System.Drawing.Size(525, 334);
            this.todaysEntriesPanel.TabIndex = 5;
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
            this.lsvTodayEntries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsvTodayEntries.Name = "lsvTodayEntries";
            this.lsvTodayEntries.Size = new System.Drawing.Size(523, 332);
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
            this.dailySummaryPanel.Location = new System.Drawing.Point(373, 404);
            this.dailySummaryPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dailySummaryPanel.Name = "dailySummaryPanel";
            this.dailySummaryPanel.Size = new System.Drawing.Size(525, 230);
            this.dailySummaryPanel.TabIndex = 6;
            // 
            // txtSummaryMostWashedVehicle
            // 
            this.txtSummaryMostWashedVehicle.Location = new System.Drawing.Point(280, 185);
            this.txtSummaryMostWashedVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryMostWashedVehicle.Name = "txtSummaryMostWashedVehicle";
            this.txtSummaryMostWashedVehicle.ReadOnly = true;
            this.txtSummaryMostWashedVehicle.Size = new System.Drawing.Size(209, 23);
            this.txtSummaryMostWashedVehicle.TabIndex = 9;
            this.txtSummaryMostWashedVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryMostWashedVehicle
            // 
            this.lblSummaryMostWashedVehicle.AutoSize = true;
            this.lblSummaryMostWashedVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryMostWashedVehicle.Location = new System.Drawing.Point(280, 162);
            this.lblSummaryMostWashedVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryMostWashedVehicle.Name = "lblSummaryMostWashedVehicle";
            this.lblSummaryMostWashedVehicle.Size = new System.Drawing.Size(134, 13);
            this.lblSummaryMostWashedVehicle.TabIndex = 8;
            this.lblSummaryMostWashedVehicle.Text = "Most Washed Vehicle:";
            // 
            // txtSummaryTotalWashes
            // 
            this.txtSummaryTotalWashes.Location = new System.Drawing.Point(18, 185);
            this.txtSummaryTotalWashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalWashes.Name = "txtSummaryTotalWashes";
            this.txtSummaryTotalWashes.ReadOnly = true;
            this.txtSummaryTotalWashes.Size = new System.Drawing.Size(209, 23);
            this.txtSummaryTotalWashes.TabIndex = 7;
            this.txtSummaryTotalWashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalWashes
            // 
            this.lblSummaryTotalWashes.AutoSize = true;
            this.lblSummaryTotalWashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTotalWashes.Location = new System.Drawing.Point(18, 162);
            this.lblSummaryTotalWashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalWashes.Name = "lblSummaryTotalWashes";
            this.lblSummaryTotalWashes.Size = new System.Drawing.Size(136, 13);
            this.lblSummaryTotalWashes.TabIndex = 6;
            this.lblSummaryTotalWashes.Text = "Total Washes (Today):";
            // 
            // txtSummaryTotalEmpShare
            // 
            this.txtSummaryTotalEmpShare.Location = new System.Drawing.Point(280, 115);
            this.txtSummaryTotalEmpShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalEmpShare.Name = "txtSummaryTotalEmpShare";
            this.txtSummaryTotalEmpShare.ReadOnly = true;
            this.txtSummaryTotalEmpShare.Size = new System.Drawing.Size(209, 23);
            this.txtSummaryTotalEmpShare.TabIndex = 5;
            this.txtSummaryTotalEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalEmpShare
            // 
            this.lblSummaryTotalEmpShare.AutoSize = true;
            this.lblSummaryTotalEmpShare.Location = new System.Drawing.Point(280, 92);
            this.lblSummaryTotalEmpShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalEmpShare.Name = "lblSummaryTotalEmpShare";
            this.lblSummaryTotalEmpShare.Size = new System.Drawing.Size(122, 15);
            this.lblSummaryTotalEmpShare.TabIndex = 4;
            this.lblSummaryTotalEmpShare.Text = "Total Employee Share:";
            // 
            // txtSummaryTotalOwnerShare
            // 
            this.txtSummaryTotalOwnerShare.Location = new System.Drawing.Point(18, 115);
            this.txtSummaryTotalOwnerShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalOwnerShare.Name = "txtSummaryTotalOwnerShare";
            this.txtSummaryTotalOwnerShare.ReadOnly = true;
            this.txtSummaryTotalOwnerShare.Size = new System.Drawing.Size(209, 23);
            this.txtSummaryTotalOwnerShare.TabIndex = 3;
            this.txtSummaryTotalOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalOwnerShare
            // 
            this.lblSummaryTotalOwnerShare.AutoSize = true;
            this.lblSummaryTotalOwnerShare.Location = new System.Drawing.Point(18, 92);
            this.lblSummaryTotalOwnerShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalOwnerShare.Name = "lblSummaryTotalOwnerShare";
            this.lblSummaryTotalOwnerShare.Size = new System.Drawing.Size(105, 15);
            this.lblSummaryTotalOwnerShare.TabIndex = 2;
            this.lblSummaryTotalOwnerShare.Text = "Total Owner Share:";
            // 
            // txtSummaryTotalRevenue
            // 
            this.txtSummaryTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummaryTotalRevenue.Location = new System.Drawing.Point(18, 46);
            this.txtSummaryTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalRevenue.Name = "txtSummaryTotalRevenue";
            this.txtSummaryTotalRevenue.ReadOnly = true;
            this.txtSummaryTotalRevenue.Size = new System.Drawing.Size(209, 20);
            this.txtSummaryTotalRevenue.TabIndex = 1;
            this.txtSummaryTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalRevenue
            // 
            this.lblSummaryTotalRevenue.AutoSize = true;
            this.lblSummaryTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTotalRevenue.Location = new System.Drawing.Point(18, 23);
            this.lblSummaryTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalRevenue.Name = "lblSummaryTotalRevenue";
            this.lblSummaryTotalRevenue.Size = new System.Drawing.Size(95, 13);
            this.lblSummaryTotalRevenue.TabIndex = 0;
            this.lblSummaryTotalRevenue.Text = "Total Revenue:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 647);
            this.Controls.Add(this.dailySummaryPanel);
            this.Controls.Add(this.todaysEntriesPanel);
            this.Controls.Add(this.washEntryPanel);
            this.Controls.Add(this.lnkChangePassword);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DashboardForm";
            this.Text = "Car Wash Management - Daily Dashboard";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.washEntryPanel.ResumeLayout(false);
            this.washEntryPanel.PerformLayout();
            this.todaysEntriesPanel.ResumeLayout(false);
            this.lsvContextMenu.ResumeLayout(false);
            this.dailySummaryPanel.ResumeLayout(false);
            this.dailySummaryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip lsvContextMenu;
        private System.Windows.Forms.ToolStripMenuItem togglePaidStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleWashStatusToolStripMenuItem;
        private System.Windows.Forms.Panel dailySummaryPanel;
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
    }
}
