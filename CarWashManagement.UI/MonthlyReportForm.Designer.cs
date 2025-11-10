using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashManagement.UI
{
    partial class MonthlyReportForm
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
            this.lblSelectMonth = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnMonthlyToggle = new System.Windows.Forms.Button();
            this.btnYearlyToggle = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.txtReportNetProfit = new System.Windows.Forms.TextBox();
            this.lblReportNetProfit = new System.Windows.Forms.Label();
            this.txtReportTotalExpenses = new System.Windows.Forms.TextBox();
            this.lblReportTotalExpenses = new System.Windows.Forms.Label();
            this.txtReportHighestDay = new System.Windows.Forms.TextBox();
            this.lblReportHighestDay = new System.Windows.Forms.Label();
            this.txtReportMostService = new System.Windows.Forms.TextBox();
            this.lblReportMostService = new System.Windows.Forms.Label();
            this.txtReportMostWashed = new System.Windows.Forms.TextBox();
            this.lblReportMostWashed = new System.Windows.Forms.Label();
            this.txtReportEmpShare = new System.Windows.Forms.TextBox();
            this.lblReportEmpShare = new System.Windows.Forms.Label();
            this.txtReportOwnerShare = new System.Windows.Forms.TextBox();
            this.lblReportOwnerShare = new System.Windows.Forms.Label();
            this.txtReportTotalWashes = new System.Windows.Forms.TextBox();
            this.lblReportTotalWashes = new System.Windows.Forms.Label();
            this.txtReportTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblReportTotalRevenue = new System.Windows.Forms.Label();
            this.lblEntries = new System.Windows.Forms.Label();
            this.lsvMonthlyEntries = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMonth
            // 
            this.lblSelectMonth.AutoSize = true;
            this.lblSelectMonth.Location = new System.Drawing.Point(12, 17);
            this.lblSelectMonth.Name = "lblSelectMonth";
            this.lblSelectMonth.Size = new System.Drawing.Size(73, 13);
            this.lblSelectMonth.TabIndex = 0;
            this.lblSelectMonth.Text = "Select Month:";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.CustomFormat = "MMMM yyyy";
            this.dtpReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportDate.Location = new System.Drawing.Point(110, 12);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(150, 20);
            this.dtpReportDate.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(270, 10);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(80, 30);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnMonthlyToggle
            // 
            this.btnMonthlyToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnMonthlyToggle.Location = new System.Drawing.Point(450, 10);
            this.btnMonthlyToggle.Name = "btnMonthlyToggle";
            this.btnMonthlyToggle.Size = new System.Drawing.Size(75, 30);
            this.btnMonthlyToggle.TabIndex = 3;
            this.btnMonthlyToggle.Text = "Monthly";
            this.btnMonthlyToggle.UseVisualStyleBackColor = false;
            // 
            // btnYearlyToggle
            // 
            this.btnYearlyToggle.Location = new System.Drawing.Point(531, 10);
            this.btnYearlyToggle.Name = "btnYearlyToggle";
            this.btnYearlyToggle.Size = new System.Drawing.Size(75, 30);
            this.btnYearlyToggle.TabIndex = 4;
            this.btnYearlyToggle.Text = "Yearly";
            this.btnYearlyToggle.UseVisualStyleBackColor = true;
            // 
            // pnlReport
            // 
            this.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReport.Controls.Add(this.txtReportNetProfit);
            this.pnlReport.Controls.Add(this.lblReportNetProfit);
            this.pnlReport.Controls.Add(this.txtReportTotalExpenses);
            this.pnlReport.Controls.Add(this.lblReportTotalExpenses);
            this.pnlReport.Controls.Add(this.txtReportHighestDay);
            this.pnlReport.Controls.Add(this.lblReportHighestDay);
            this.pnlReport.Controls.Add(this.txtReportMostService);
            this.pnlReport.Controls.Add(this.lblReportMostService);
            this.pnlReport.Controls.Add(this.txtReportMostWashed);
            this.pnlReport.Controls.Add(this.lblReportMostWashed);
            this.pnlReport.Controls.Add(this.txtReportEmpShare);
            this.pnlReport.Controls.Add(this.lblReportEmpShare);
            this.pnlReport.Controls.Add(this.txtReportOwnerShare);
            this.pnlReport.Controls.Add(this.lblReportOwnerShare);
            this.pnlReport.Controls.Add(this.txtReportTotalWashes);
            this.pnlReport.Controls.Add(this.lblReportTotalWashes);
            this.pnlReport.Controls.Add(this.txtReportTotalRevenue);
            this.pnlReport.Controls.Add(this.lblReportTotalRevenue);
            this.pnlReport.Location = new System.Drawing.Point(15, 50);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(590, 320);
            this.pnlReport.TabIndex = 5;
            // 
            // txtReportNetProfit
            // 
            this.txtReportNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportNetProfit.Location = new System.Drawing.Point(300, 262);
            this.txtReportNetProfit.Name = "txtReportNetProfit";
            this.txtReportNetProfit.ReadOnly = true;
            this.txtReportNetProfit.Size = new System.Drawing.Size(180, 20);
            this.txtReportNetProfit.TabIndex = 17;
            this.txtReportNetProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportNetProfit
            // 
            this.lblReportNetProfit.AutoSize = true;
            this.lblReportNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportNetProfit.Location = new System.Drawing.Point(297, 242);
            this.lblReportNetProfit.Name = "lblReportNetProfit";
            this.lblReportNetProfit.Size = new System.Drawing.Size(113, 13);
            this.lblReportNetProfit.TabIndex = 16;
            this.lblReportNetProfit.Text = "Net Profit (Owner):";
            // 
            // txtReportTotalExpenses
            // 
            this.txtReportTotalExpenses.Location = new System.Drawing.Point(15, 262);
            this.txtReportTotalExpenses.Name = "txtReportTotalExpenses";
            this.txtReportTotalExpenses.ReadOnly = true;
            this.txtReportTotalExpenses.Size = new System.Drawing.Size(180, 20);
            this.txtReportTotalExpenses.TabIndex = 15;
            this.txtReportTotalExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalExpenses
            // 
            this.lblReportTotalExpenses.AutoSize = true;
            this.lblReportTotalExpenses.Location = new System.Drawing.Point(12, 242);
            this.lblReportTotalExpenses.Name = "lblReportTotalExpenses";
            this.lblReportTotalExpenses.Size = new System.Drawing.Size(84, 13);
            this.lblReportTotalExpenses.TabIndex = 14;
            this.lblReportTotalExpenses.Text = "Total Expenses:";
            // 
            // txtReportHighestDay
            // 
            this.txtReportHighestDay.Location = new System.Drawing.Point(15, 207);
            this.txtReportHighestDay.Name = "txtReportHighestDay";
            this.txtReportHighestDay.ReadOnly = true;
            this.txtReportHighestDay.Size = new System.Drawing.Size(180, 20);
            this.txtReportHighestDay.TabIndex = 13;
            this.txtReportHighestDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportHighestDay
            // 
            this.lblReportHighestDay.AutoSize = true;
            this.lblReportHighestDay.Location = new System.Drawing.Point(12, 187);
            this.lblReportHighestDay.Name = "lblReportHighestDay";
            this.lblReportHighestDay.Size = new System.Drawing.Size(113, 13);
            this.lblReportHighestDay.TabIndex = 12;
            this.lblReportHighestDay.Text = "Highest Revenue Day:";
            // 
            // txtReportMostService
            // 
            this.txtReportMostService.Location = new System.Drawing.Point(300, 152);
            this.txtReportMostService.Name = "txtReportMostService";
            this.txtReportMostService.ReadOnly = true;
            this.txtReportMostService.Size = new System.Drawing.Size(180, 20);
            this.txtReportMostService.TabIndex = 11;
            this.txtReportMostService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportMostService
            // 
            this.lblReportMostService.AutoSize = true;
            this.lblReportMostService.Location = new System.Drawing.Point(297, 132);
            this.lblReportMostService.Name = "lblReportMostService";
            this.lblReportMostService.Size = new System.Drawing.Size(110, 13);
            this.lblReportMostService.TabIndex = 10;
            this.lblReportMostService.Text = "Most Availed Service:";
            // 
            // txtReportMostWashed
            // 
            this.txtReportMostWashed.Location = new System.Drawing.Point(15, 152);
            this.txtReportMostWashed.Name = "txtReportMostWashed";
            this.txtReportMostWashed.ReadOnly = true;
            this.txtReportMostWashed.Size = new System.Drawing.Size(180, 20);
            this.txtReportMostWashed.TabIndex = 9;
            this.txtReportMostWashed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportMostWashed
            // 
            this.lblReportMostWashed.AutoSize = true;
            this.lblReportMostWashed.Location = new System.Drawing.Point(12, 132);
            this.lblReportMostWashed.Name = "lblReportMostWashed";
            this.lblReportMostWashed.Size = new System.Drawing.Size(113, 13);
            this.lblReportMostWashed.TabIndex = 8;
            this.lblReportMostWashed.Text = "Most Washed Vehicle:";
            // 
            // txtReportEmpShare
            // 
            this.txtReportEmpShare.Location = new System.Drawing.Point(300, 97);
            this.txtReportEmpShare.Name = "txtReportEmpShare";
            this.txtReportEmpShare.ReadOnly = true;
            this.txtReportEmpShare.Size = new System.Drawing.Size(180, 20);
            this.txtReportEmpShare.TabIndex = 7;
            this.txtReportEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportEmpShare
            // 
            this.lblReportEmpShare.AutoSize = true;
            this.lblReportEmpShare.Location = new System.Drawing.Point(297, 77);
            this.lblReportEmpShare.Name = "lblReportEmpShare";
            this.lblReportEmpShare.Size = new System.Drawing.Size(120, 13);
            this.lblReportEmpShare.TabIndex = 6;
            this.lblReportEmpShare.Text = "Total Employee Share:";
            // 
            // txtReportOwnerShare
            // 
            this.txtReportOwnerShare.Location = new System.Drawing.Point(15, 97);
            this.txtReportOwnerShare.Name = "txtReportOwnerShare";
            this.txtReportOwnerShare.ReadOnly = true;
            this.txtReportOwnerShare.Size = new System.Drawing.Size(180, 20);
            this.txtReportOwnerShare.TabIndex = 5;
            this.txtReportOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportOwnerShare
            // 
            this.lblReportOwnerShare.AutoSize = true;
            this.lblReportOwnerShare.Location = new System.Drawing.Point(12, 77);
            this.lblReportOwnerShare.Name = "lblReportOwnerShare";
            this.lblReportOwnerShare.Size = new System.Drawing.Size(104, 13);
            this.lblReportOwnerShare.TabIndex = 4;
            this.lblReportOwnerShare.Text = "Total Owner Share:";
            // 
            // txtReportTotalWashes
            // 
            this.txtReportTotalWashes.Location = new System.Drawing.Point(300, 42);
            this.txtReportTotalWashes.Name = "txtReportTotalWashes";
            this.txtReportTotalWashes.ReadOnly = true;
            this.txtReportTotalWashes.Size = new System.Drawing.Size(180, 20);
            this.txtReportTotalWashes.TabIndex = 3;
            this.txtReportTotalWashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalWashes
            // 
            this.lblReportTotalWashes.AutoSize = true;
            this.lblReportTotalWashes.Location = new System.Drawing.Point(297, 22);
            this.lblReportTotalWashes.Name = "lblReportTotalWashes";
            this.lblReportTotalWashes.Size = new System.Drawing.Size(77, 13);
            this.lblReportTotalWashes.TabIndex = 2;
            this.lblReportTotalWashes.Text = "Total Washes:";
            // 
            // txtReportTotalRevenue
            // 
            this.txtReportTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportTotalRevenue.Location = new System.Drawing.Point(15, 42);
            this.txtReportTotalRevenue.Name = "txtReportTotalRevenue";
            this.txtReportTotalRevenue.ReadOnly = true;
            this.txtReportTotalRevenue.Size = new System.Drawing.Size(180, 20);
            this.txtReportTotalRevenue.TabIndex = 1;
            this.txtReportTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalRevenue
            // 
            this.lblReportTotalRevenue.AutoSize = true;
            this.lblReportTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTotalRevenue.Location = new System.Drawing.Point(12, 22);
            this.lblReportTotalRevenue.Name = "lblReportTotalRevenue";
            this.lblReportTotalRevenue.Size = new System.Drawing.Size(96, 13);
            this.lblReportTotalRevenue.TabIndex = 0;
            this.lblReportTotalRevenue.Text = "Total Revenue:";
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntries.Location = new System.Drawing.Point(12, 385);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(46, 13);
            this.lblEntries.TabIndex = 6;
            this.lblEntries.Text = "Entries";
            // 
            // lsvMonthlyEntries
            // 
            this.lsvMonthlyEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvMonthlyEntries.FullRowSelect = true;
            this.lsvMonthlyEntries.GridLines = true;
            this.lsvMonthlyEntries.HideSelection = false;
            this.lsvMonthlyEntries.Location = new System.Drawing.Point(15, 410);
            this.lsvMonthlyEntries.Name = "lsvMonthlyEntries";
            this.lsvMonthlyEntries.Size = new System.Drawing.Size(590, 285);
            this.lsvMonthlyEntries.TabIndex = 7;
            this.lsvMonthlyEntries.UseCompatibleStateImageBehavior = false;
            this.lsvMonthlyEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vehicle";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Employee";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Owner Share";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Employee Share";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Payment Status";
            this.columnHeader6.Width = 100;
            // 
            // MonthlyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 711);
            this.Controls.Add(this.lsvMonthlyEntries);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.btnYearlyToggle);
            this.Controls.Add(this.btnMonthlyToggle);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dtpReportDate);
            this.Controls.Add(this.lblSelectMonth);
            this.Name = "MonthlyReportForm";
            this.Text = "Monthly/Yearly Report Dashboard";
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblSelectMonth;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnMonthlyToggle;
        private System.Windows.Forms.Button btnYearlyToggle;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Label lblReportTotalRevenue;
        private System.Windows.Forms.TextBox txtReportTotalRevenue;
        private System.Windows.Forms.Label lblReportTotalWashes;
        private System.Windows.Forms.TextBox txtReportTotalWashes;
        private System.Windows.Forms.Label lblReportOwnerShare;
        private System.Windows.Forms.TextBox txtReportOwnerShare;
        private System.Windows.Forms.Label lblReportEmpShare;
        private System.Windows.Forms.TextBox txtReportEmpShare;
        private System.Windows.Forms.Label lblReportMostWashed;
        private System.Windows.Forms.TextBox txtReportMostWashed;
        private System.Windows.Forms.Label lblReportMostService;
        private System.Windows.Forms.TextBox txtReportMostService;
        private System.Windows.Forms.Label lblReportHighestDay;
        private System.Windows.Forms.TextBox txtReportHighestDay;
        private System.Windows.Forms.Label lblReportTotalExpenses;
        private System.Windows.Forms.TextBox txtReportTotalExpenses;
        private System.Windows.Forms.Label lblReportNetProfit;
        private System.Windows.Forms.TextBox txtReportNetProfit;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.ListView lsvMonthlyEntries;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
