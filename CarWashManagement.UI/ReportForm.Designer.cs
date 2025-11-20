using System.Drawing;
using System.Windows.Forms;

namespace CarWashManagement.UI
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.lblSelectMonth = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnMonthlyToggle = new System.Windows.Forms.Button();
            this.btnYearlyToggle = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.lblReportNetProfit = new System.Windows.Forms.Label();
            this.txtReportNetProfit = new System.Windows.Forms.TextBox();
            this.lblReportTotalExpenses = new System.Windows.Forms.Label();
            this.txtReportTotalExpenses = new System.Windows.Forms.TextBox();
            this.lblReportHighestDay = new System.Windows.Forms.Label();
            this.txtReportHighestDay = new System.Windows.Forms.TextBox();
            this.lblReportMostService = new System.Windows.Forms.Label();
            this.txtReportMostService = new System.Windows.Forms.TextBox();
            this.lblReportMostWashed = new System.Windows.Forms.Label();
            this.txtReportMostWashed = new System.Windows.Forms.TextBox();
            this.lblReportEmpShare = new System.Windows.Forms.Label();
            this.txtReportEmpShare = new System.Windows.Forms.TextBox();
            this.lblReportOwnerShare = new System.Windows.Forms.Label();
            this.txtReportOwnerShare = new System.Windows.Forms.TextBox();
            this.lblReportTotalWashes = new System.Windows.Forms.Label();
            this.txtReportTotalWashes = new System.Windows.Forms.TextBox();
            this.lblReportTotalRevenue = new System.Windows.Forms.Label();
            this.txtReportTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblEntries = new System.Windows.Forms.Label();
            this.lsvMonthlyEntries = new System.Windows.Forms.ListView();
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOwnerShare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmployeeShare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPaymentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMonth
            // 
            this.lblSelectMonth.AutoSize = true;
            this.lblSelectMonth.Location = new System.Drawing.Point(32, 20);
            this.lblSelectMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectMonth.Name = "lblSelectMonth";
            this.lblSelectMonth.Size = new System.Drawing.Size(73, 15);
            this.lblSelectMonth.TabIndex = 0;
            this.lblSelectMonth.Text = "Chọn tháng:";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.CustomFormat = "MMMM yyyy";
            this.dtpReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportDate.Location = new System.Drawing.Point(128, 14);
            this.dtpReportDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(174, 23);
            this.dtpReportDate.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(315, 12);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(45, 35);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Tạo";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnMonthlyToggle
            // 
            this.btnMonthlyToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMonthlyToggle.FlatAppearance.BorderSize = 0;
            this.btnMonthlyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyToggle.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyToggle.Location = new System.Drawing.Point(525, 12);
            this.btnMonthlyToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMonthlyToggle.Name = "btnMonthlyToggle";
            this.btnMonthlyToggle.Size = new System.Drawing.Size(88, 35);
            this.btnMonthlyToggle.TabIndex = 3;
            this.btnMonthlyToggle.Text = "Theo tháng";
            this.btnMonthlyToggle.UseVisualStyleBackColor = false;
            this.btnMonthlyToggle.Click += new System.EventHandler(this.btnMonthlyToggle_Click);
            // 
            // btnYearlyToggle
            // 
            this.btnYearlyToggle.BackColor = System.Drawing.Color.White;
            this.btnYearlyToggle.FlatAppearance.BorderSize = 0;
            this.btnYearlyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearlyToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnYearlyToggle.Location = new System.Drawing.Point(618, 12);
            this.btnYearlyToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYearlyToggle.Name = "btnYearlyToggle";
            this.btnYearlyToggle.Size = new System.Drawing.Size(88, 35);
            this.btnYearlyToggle.TabIndex = 4;
            this.btnYearlyToggle.Text = "Theo năm";
            this.btnYearlyToggle.UseVisualStyleBackColor = false;
            this.btnYearlyToggle.Click += new System.EventHandler(this.btnYearlyToggle_Click);
            // 
            // pnlReport
            // 
            this.pnlReport.BackColor = System.Drawing.Color.White;
            this.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReport.Controls.Add(this.lblReportNetProfit);
            this.pnlReport.Controls.Add(this.txtReportNetProfit);
            this.pnlReport.Controls.Add(this.lblReportTotalExpenses);
            this.pnlReport.Controls.Add(this.txtReportTotalExpenses);
            this.pnlReport.Controls.Add(this.lblReportHighestDay);
            this.pnlReport.Controls.Add(this.txtReportHighestDay);
            this.pnlReport.Controls.Add(this.lblReportMostService);
            this.pnlReport.Controls.Add(this.txtReportMostService);
            this.pnlReport.Controls.Add(this.lblReportMostWashed);
            this.pnlReport.Controls.Add(this.txtReportMostWashed);
            this.pnlReport.Controls.Add(this.lblReportEmpShare);
            this.pnlReport.Controls.Add(this.txtReportEmpShare);
            this.pnlReport.Controls.Add(this.lblReportOwnerShare);
            this.pnlReport.Controls.Add(this.txtReportOwnerShare);
            this.pnlReport.Controls.Add(this.lblReportTotalWashes);
            this.pnlReport.Controls.Add(this.txtReportTotalWashes);
            this.pnlReport.Controls.Add(this.lblReportTotalRevenue);
            this.pnlReport.Controls.Add(this.txtReportTotalRevenue);
            this.pnlReport.Location = new System.Drawing.Point(18, 58);
            this.pnlReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(688, 369);
            this.pnlReport.TabIndex = 5;
            // 
            // lblReportNetProfit
            // 
            this.lblReportNetProfit.AutoSize = true;
            this.lblReportNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblReportNetProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportNetProfit.Location = new System.Drawing.Point(350, 283);
            this.lblReportNetProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportNetProfit.Name = "lblReportNetProfit";
            this.lblReportNetProfit.Size = new System.Drawing.Size(167, 13);
            this.lblReportNetProfit.TabIndex = 17;
            this.lblReportNetProfit.Text = "Lợi nhuận ròng của công ty:";
            // 
            // txtReportNetProfit
            // 
            this.txtReportNetProfit.BackColor = System.Drawing.Color.White;
            this.txtReportNetProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtReportNetProfit.Location = new System.Drawing.Point(350, 306);
            this.txtReportNetProfit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportNetProfit.Name = "txtReportNetProfit";
            this.txtReportNetProfit.ReadOnly = true;
            this.txtReportNetProfit.Size = new System.Drawing.Size(210, 20);
            this.txtReportNetProfit.TabIndex = 16;
            this.txtReportNetProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalExpenses
            // 
            this.lblReportTotalExpenses.AutoSize = true;
            this.lblReportTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportTotalExpenses.Location = new System.Drawing.Point(18, 283);
            this.lblReportTotalExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportTotalExpenses.Name = "lblReportTotalExpenses";
            this.lblReportTotalExpenses.Size = new System.Drawing.Size(76, 15);
            this.lblReportTotalExpenses.TabIndex = 15;
            this.lblReportTotalExpenses.Text = "Tổng chi phí:";
            // 
            // txtReportTotalExpenses
            // 
            this.txtReportTotalExpenses.BackColor = System.Drawing.Color.White;
            this.txtReportTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportTotalExpenses.Location = new System.Drawing.Point(18, 306);
            this.txtReportTotalExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportTotalExpenses.Name = "txtReportTotalExpenses";
            this.txtReportTotalExpenses.ReadOnly = true;
            this.txtReportTotalExpenses.Size = new System.Drawing.Size(210, 23);
            this.txtReportTotalExpenses.TabIndex = 14;
            this.txtReportTotalExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportHighestDay
            // 
            this.lblReportHighestDay.AutoSize = true;
            this.lblReportHighestDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportHighestDay.Location = new System.Drawing.Point(18, 219);
            this.lblReportHighestDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportHighestDay.Name = "lblReportHighestDay";
            this.lblReportHighestDay.Size = new System.Drawing.Size(117, 15);
            this.lblReportHighestDay.TabIndex = 13;
            this.lblReportHighestDay.Text = "Ngày cao điểm nhất:";
            // 
            // txtReportHighestDay
            // 
            this.txtReportHighestDay.BackColor = System.Drawing.Color.White;
            this.txtReportHighestDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportHighestDay.Location = new System.Drawing.Point(18, 242);
            this.txtReportHighestDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportHighestDay.Name = "txtReportHighestDay";
            this.txtReportHighestDay.ReadOnly = true;
            this.txtReportHighestDay.Size = new System.Drawing.Size(210, 23);
            this.txtReportHighestDay.TabIndex = 12;
            this.txtReportHighestDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportMostService
            // 
            this.lblReportMostService.AutoSize = true;
            this.lblReportMostService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportMostService.Location = new System.Drawing.Point(350, 156);
            this.lblReportMostService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportMostService.Name = "lblReportMostService";
            this.lblReportMostService.Size = new System.Drawing.Size(189, 15);
            this.lblReportMostService.TabIndex = 11;
            this.lblReportMostService.Text = "Dịch vụ được lựa chọn nhiều nhất:";
            // 
            // txtReportMostService
            // 
            this.txtReportMostService.BackColor = System.Drawing.Color.White;
            this.txtReportMostService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportMostService.Location = new System.Drawing.Point(350, 179);
            this.txtReportMostService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportMostService.Name = "txtReportMostService";
            this.txtReportMostService.ReadOnly = true;
            this.txtReportMostService.Size = new System.Drawing.Size(210, 23);
            this.txtReportMostService.TabIndex = 10;
            this.txtReportMostService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportMostWashed
            // 
            this.lblReportMostWashed.AutoSize = true;
            this.lblReportMostWashed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportMostWashed.Location = new System.Drawing.Point(18, 156);
            this.lblReportMostWashed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportMostWashed.Name = "lblReportMostWashed";
            this.lblReportMostWashed.Size = new System.Drawing.Size(152, 15);
            this.lblReportMostWashed.TabIndex = 9;
            this.lblReportMostWashed.Text = "Phương tiện phổ biến nhất:";
            // 
            // txtReportMostWashed
            // 
            this.txtReportMostWashed.BackColor = System.Drawing.Color.White;
            this.txtReportMostWashed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportMostWashed.Location = new System.Drawing.Point(18, 179);
            this.txtReportMostWashed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportMostWashed.Name = "txtReportMostWashed";
            this.txtReportMostWashed.ReadOnly = true;
            this.txtReportMostWashed.Size = new System.Drawing.Size(210, 23);
            this.txtReportMostWashed.TabIndex = 8;
            this.txtReportMostWashed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportEmpShare
            // 
            this.lblReportEmpShare.AutoSize = true;
            this.lblReportEmpShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportEmpShare.Location = new System.Drawing.Point(350, 92);
            this.lblReportEmpShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportEmpShare.Name = "lblReportEmpShare";
            this.lblReportEmpShare.Size = new System.Drawing.Size(122, 15);
            this.lblReportEmpShare.TabIndex = 7;
            this.lblReportEmpShare.Text = "Nhân Viên thực nhận:";
            // 
            // txtReportEmpShare
            // 
            this.txtReportEmpShare.BackColor = System.Drawing.Color.White;
            this.txtReportEmpShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportEmpShare.Location = new System.Drawing.Point(350, 115);
            this.txtReportEmpShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportEmpShare.Name = "txtReportEmpShare";
            this.txtReportEmpShare.ReadOnly = true;
            this.txtReportEmpShare.Size = new System.Drawing.Size(210, 23);
            this.txtReportEmpShare.TabIndex = 6;
            this.txtReportEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportOwnerShare
            // 
            this.lblReportOwnerShare.AutoSize = true;
            this.lblReportOwnerShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportOwnerShare.Location = new System.Drawing.Point(18, 92);
            this.lblReportOwnerShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportOwnerShare.Name = "lblReportOwnerShare";
            this.lblReportOwnerShare.Size = new System.Drawing.Size(109, 15);
            this.lblReportOwnerShare.TabIndex = 5;
            this.lblReportOwnerShare.Text = "Công ty thực nhận:";
            // 
            // txtReportOwnerShare
            // 
            this.txtReportOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtReportOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportOwnerShare.Location = new System.Drawing.Point(18, 115);
            this.txtReportOwnerShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportOwnerShare.Name = "txtReportOwnerShare";
            this.txtReportOwnerShare.ReadOnly = true;
            this.txtReportOwnerShare.Size = new System.Drawing.Size(210, 23);
            this.txtReportOwnerShare.TabIndex = 4;
            this.txtReportOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalWashes
            // 
            this.lblReportTotalWashes.AutoSize = true;
            this.lblReportTotalWashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportTotalWashes.Location = new System.Drawing.Point(350, 29);
            this.lblReportTotalWashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportTotalWashes.Name = "lblReportTotalWashes";
            this.lblReportTotalWashes.Size = new System.Drawing.Size(91, 15);
            this.lblReportTotalWashes.TabIndex = 3;
            this.lblReportTotalWashes.Text = "Tổng lượng rửa:";
            // 
            // txtReportTotalWashes
            // 
            this.txtReportTotalWashes.BackColor = System.Drawing.Color.White;
            this.txtReportTotalWashes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportTotalWashes.Location = new System.Drawing.Point(350, 52);
            this.txtReportTotalWashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportTotalWashes.Name = "txtReportTotalWashes";
            this.txtReportTotalWashes.ReadOnly = true;
            this.txtReportTotalWashes.Size = new System.Drawing.Size(210, 23);
            this.txtReportTotalWashes.TabIndex = 2;
            this.txtReportTotalWashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalRevenue
            // 
            this.lblReportTotalRevenue.AutoSize = true;
            this.lblReportTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportTotalRevenue.Location = new System.Drawing.Point(18, 29);
            this.lblReportTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportTotalRevenue.Name = "lblReportTotalRevenue";
            this.lblReportTotalRevenue.Size = new System.Drawing.Size(95, 15);
            this.lblReportTotalRevenue.TabIndex = 1;
            this.lblReportTotalRevenue.Text = "Tổng doanh thu:";
            // 
            // txtReportTotalRevenue
            // 
            this.txtReportTotalRevenue.BackColor = System.Drawing.Color.White;
            this.txtReportTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtReportTotalRevenue.Location = new System.Drawing.Point(18, 52);
            this.txtReportTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReportTotalRevenue.Name = "txtReportTotalRevenue";
            this.txtReportTotalRevenue.ReadOnly = true;
            this.txtReportTotalRevenue.Size = new System.Drawing.Size(210, 20);
            this.txtReportTotalRevenue.TabIndex = 0;
            this.txtReportTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblEntries.Location = new System.Drawing.Point(18, 444);
            this.lblEntries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(109, 20);
            this.lblEntries.TabIndex = 6;
            this.lblEntries.Text = "Phiếu hóa đơn";
            // 
            // lsvMonthlyEntries
            // 
            this.lsvMonthlyEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime,
            this.columnVehicle,
            this.columnEmployee,
            this.columnOwnerShare,
            this.columnEmployeeShare,
            this.columnPaymentStatus});
            this.lsvMonthlyEntries.FullRowSelect = true;
            this.lsvMonthlyEntries.GridLines = true;
            this.lsvMonthlyEntries.HideSelection = false;
            this.lsvMonthlyEntries.Location = new System.Drawing.Point(18, 473);
            this.lsvMonthlyEntries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsvMonthlyEntries.Name = "lsvMonthlyEntries";
            this.lsvMonthlyEntries.Size = new System.Drawing.Size(688, 328);
            this.lsvMonthlyEntries.TabIndex = 7;
            this.lsvMonthlyEntries.UseCompatibleStateImageBehavior = false;
            this.lsvMonthlyEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.Width = 70;
            // 
            // columnVehicle
            // 
            this.columnVehicle.Text = "Vehicle";
            this.columnVehicle.Width = 90;
            // 
            // columnEmployee
            // 
            this.columnEmployee.Text = "Employee";
            this.columnEmployee.Width = 100;
            // 
            // columnOwnerShare
            // 
            this.columnOwnerShare.Text = "Owner Share";
            this.columnOwnerShare.Width = 136;
            // 
            // columnEmployeeShare
            // 
            this.columnEmployeeShare.Text = "Employee Share";
            this.columnEmployeeShare.Width = 120;
            // 
            // columnPaymentStatus
            // 
            this.columnPaymentStatus.Text = "Payment Status";
            this.columnPaymentStatus.Width = 100;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 832);
            this.Controls.Add(this.lsvMonthlyEntries);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.btnYearlyToggle);
            this.Controls.Add(this.btnMonthlyToggle);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dtpReportDate);
            this.Controls.Add(this.lblSelectMonth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReportForm";
            this.Text = "Monthly/Yearly Report Dashboard";
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSelectMonth;
        private DateTimePicker dtpReportDate;
        private Button btnGenerateReport;
        private Button btnMonthlyToggle;
        private Button btnYearlyToggle;
        private Panel pnlReport;
        private Label lblReportTotalRevenue;
        private TextBox txtReportTotalRevenue;
        private Label lblReportTotalWashes;
        private TextBox txtReportTotalWashes;
        private Label lblReportOwnerShare;
        private TextBox txtReportOwnerShare;
        private Label lblReportEmpShare;
        private TextBox txtReportEmpShare;
        private Label lblReportMostWashed;
        private TextBox txtReportMostWashed;
        private Label lblReportMostService;
        private TextBox txtReportMostService;
        private Label lblReportHighestDay;
        private TextBox txtReportHighestDay;
        private Label lblReportTotalExpenses;
        private TextBox txtReportTotalExpenses;
        private Label lblReportNetProfit;
        private TextBox txtReportNetProfit;
        private Label lblEntries;
        private ListView lsvMonthlyEntries;
        private ColumnHeader columnTime;
        private ColumnHeader columnVehicle;
        private ColumnHeader columnEmployee;
        private ColumnHeader columnOwnerShare;
        private ColumnHeader columnEmployeeShare;
        private ColumnHeader columnPaymentStatus;
    }
}