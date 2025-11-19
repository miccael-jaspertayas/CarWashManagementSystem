using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.lblSelectMonth = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.lblEntries = new System.Windows.Forms.Label();
            this.lsvMonthlyEntries = new System.Windows.Forms.ListView();
            this.btnMonthlyToggle = new System.Windows.Forms.Button();
            this.btnYearlyToggle = new System.Windows.Forms.Button();
            this.lblReportTotalRevenue = new System.Windows.Forms.Label();
            this.txtReportTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblReportOwnerShare = new System.Windows.Forms.Label();
            this.txtReportOwnerShare = new System.Windows.Forms.TextBox();
            this.lblReportEmpShare = new System.Windows.Forms.Label();
            this.txtReportEmpShare = new System.Windows.Forms.TextBox();
            this.lblReportTotalWashes = new System.Windows.Forms.Label();
            this.txtReportTotalWashes = new System.Windows.Forms.TextBox();
            this.lblReportMostWashed = new System.Windows.Forms.Label();
            this.txtReportMostWashed = new System.Windows.Forms.TextBox();
            this.lblReportMostService = new System.Windows.Forms.Label();
            this.txtReportMostService = new System.Windows.Forms.TextBox();
            this.lblReportHighestDay = new System.Windows.Forms.Label();
            this.txtReportHighestDay = new System.Windows.Forms.TextBox();
            this.lblReportTotalExpenses = new System.Windows.Forms.Label();
            this.txtReportTotalExpenses = new System.Windows.Forms.TextBox();
            this.lblReportNetProfit = new System.Windows.Forms.Label();
            this.txtReportNetProfit = new System.Windows.Forms.TextBox();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMonth
            // 
            this.lblSelectMonth.AutoSize = true;
            this.lblSelectMonth.Location = new System.Drawing.Point(15, 15);
            this.lblSelectMonth.Name = "lblSelectMonth";
            this.lblSelectMonth.Size = new System.Drawing.Size(89, 15);
            this.lblSelectMonth.TabIndex = 0;
            this.lblSelectMonth.Text = "Select Month:";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.CustomFormat = "MMMM yyyy";
            this.dtpReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportDate.Location = new System.Drawing.Point(110, 12);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(150, 23);
            this.dtpReportDate.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(270, 10);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(80, 30);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
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
            this.pnlReport.Location = new System.Drawing.Point(15, 50);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(590, 320);
            this.pnlReport.TabIndex = 3;
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblEntries.Location = new System.Drawing.Point(15, 385);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(56, 20);
            this.lblEntries.TabIndex = 4;
            this.lblEntries.Text = "Entries";
            // 
            // lsvMonthlyEntries
            // 
            this.lsvMonthlyEntries.FullRowSelect = true;
            this.lsvMonthlyEntries.GridLines = true;
            this.lsvMonthlyEntries.Location = new System.Drawing.Point(15, 410);
            this.lsvMonthlyEntries.Name = "lsvMonthlyEntries";
            this.lsvMonthlyEntries.Size = new System.Drawing.Size(590, 285);
            this.lsvMonthlyEntries.TabIndex = 5;
            this.lsvMonthlyEntries.UseCompatibleStateImageBehavior = false;
            this.lsvMonthlyEntries.View = System.Windows.Forms.View.Details;
            // 
            // btnMonthlyToggle
            // 
            this.btnMonthlyToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMonthlyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyToggle.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyToggle.Location = new System.Drawing.Point(450, 10);
            this.btnMonthlyToggle.Name = "btnMonthlyToggle";
            this.btnMonthlyToggle.Size = new System.Drawing.Size(75, 30);
            this.btnMonthlyToggle.TabIndex = 6;
            this.btnMonthlyToggle.Text = "Monthly";
            this.btnMonthlyToggle.UseVisualStyleBackColor = false;
            this.btnMonthlyToggle.Click += new System.EventHandler(this.btnMonthlyToggle_Click);
            // 
            // btnYearlyToggle
            // 
            this.btnYearlyToggle.BackColor = System.Drawing.Color.White;
            this.btnYearlyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearlyToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnYearlyToggle.Location = new System.Drawing.Point(530, 10);
            this.btnYearlyToggle.Name = "btnYearlyToggle";
            this.btnYearlyToggle.Size = new System.Drawing.Size(75, 30);
            this.btnYearlyToggle.TabIndex = 7;
            this.btnYearlyToggle.Text = "Yearly";
            this.btnYearlyToggle.UseVisualStyleBackColor = false;
            this.btnYearlyToggle.Click += new System.EventHandler(this.btnYearlyToggle_Click);
            // 
            // lblReportTotalRevenue
            // 
            this.lblReportTotalRevenue.AutoSize = true;
            this.lblReportTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportTotalRevenue.Location = new System.Drawing.Point(15, 20);
            this.lblReportTotalRevenue.Name = "lblReportTotalRevenue";
            this.lblReportTotalRevenue.Size = new System.Drawing.Size(89, 15);
            this.lblReportTotalRevenue.TabIndex = 0;
            this.lblReportTotalRevenue.Text = "Total Revenue:";
            // 
            // txtReportTotalRevenue
            // 
            this.txtReportTotalRevenue.BackColor = System.Drawing.Color.White;
            this.txtReportTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtReportTotalRevenue.Location = new System.Drawing.Point(15, 40);
            this.txtReportTotalRevenue.Name = "txtReportTotalRevenue";
            this.txtReportTotalRevenue.ReadOnly = true;
            this.txtReportTotalRevenue.Size = new System.Drawing.Size(180, 23);
            this.txtReportTotalRevenue.TabIndex = 1;
            this.txtReportTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportOwnerShare
            // 
            this.lblReportOwnerShare.AutoSize = true;
            this.lblReportOwnerShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportOwnerShare.Location = new System.Drawing.Point(15, 75);
            this.lblReportOwnerShare.Name = "lblReportOwnerShare";
            this.lblReportOwnerShare.Size = new System.Drawing.Size(117, 15);
            this.lblReportOwnerShare.TabIndex = 2;
            this.lblReportOwnerShare.Text = "Total Owner Share:";
            // 
            // txtReportOwnerShare
            // 
            this.txtReportOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtReportOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportOwnerShare.Location = new System.Drawing.Point(15, 95);
            this.txtReportOwnerShare.Name = "txtReportOwnerShare";
            this.txtReportOwnerShare.ReadOnly = true;
            this.txtReportOwnerShare.Size = new System.Drawing.Size(180, 23);
            this.txtReportOwnerShare.TabIndex = 3;
            this.txtReportOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportEmpShare
            // 
            this.lblReportEmpShare.AutoSize = true;
            this.lblReportEmpShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportEmpShare.Location = new System.Drawing.Point(300, 75);
            this.lblReportEmpShare.Name = "lblReportEmpShare";
            this.lblReportEmpShare.Size = new System.Drawing.Size(133, 15);
            this.lblReportEmpShare.TabIndex = 4;
            this.lblReportEmpShare.Text = "Total Employee Share:";
            // 
            // txtReportEmpShare
            // 
            this.txtReportEmpShare.BackColor = System.Drawing.Color.White;
            this.txtReportEmpShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportEmpShare.Location = new System.Drawing.Point(300, 95);
            this.txtReportEmpShare.Name = "txtReportEmpShare";
            this.txtReportEmpShare.ReadOnly = true;
            this.txtReportEmpShare.Size = new System.Drawing.Size(180, 23);
            this.txtReportEmpShare.TabIndex = 5;
            this.txtReportEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalWashes
            // 
            this.lblReportTotalWashes.AutoSize = true;
            this.lblReportTotalWashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportTotalWashes.Location = new System.Drawing.Point(300, 20);
            this.lblReportTotalWashes.Name = "lblReportTotalWashes";
            this.lblReportTotalWashes.Size = new System.Drawing.Size(84, 15);
            this.lblReportTotalWashes.TabIndex = 6;
            this.lblReportTotalWashes.Text = "Total Washes:";
            // 
            // txtReportTotalWashes
            // 
            this.txtReportTotalWashes.BackColor = System.Drawing.Color.White;
            this.txtReportTotalWashes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportTotalWashes.Location = new System.Drawing.Point(300, 40);
            this.txtReportTotalWashes.Name = "txtReportTotalWashes";
            this.txtReportTotalWashes.ReadOnly = true;
            this.txtReportTotalWashes.Size = new System.Drawing.Size(180, 23);
            this.txtReportTotalWashes.TabIndex = 7;
            this.txtReportTotalWashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportMostWashed
            // 
            this.lblReportMostWashed.AutoSize = true;
            this.lblReportMostWashed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportMostWashed.Location = new System.Drawing.Point(15, 130);
            this.lblReportMostWashed.Name = "lblReportMostWashed";
            this.lblReportMostWashed.Size = new System.Drawing.Size(127, 15);
            this.lblReportMostWashed.TabIndex = 8;
            this.lblReportMostWashed.Text = "Most Washed Vehicle:";
            // 
            // txtReportMostWashed
            // 
            this.txtReportMostWashed.BackColor = System.Drawing.Color.White;
            this.txtReportMostWashed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportMostWashed.Location = new System.Drawing.Point(15, 150);
            this.txtReportMostWashed.Name = "txtReportMostWashed";
            this.txtReportMostWashed.ReadOnly = true;
            this.txtReportMostWashed.Size = new System.Drawing.Size(180, 23);
            this.txtReportMostWashed.TabIndex = 9;
            this.txtReportMostWashed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportMostService
            // 
            this.lblReportMostService.AutoSize = true;
            this.lblReportMostService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportMostService.Location = new System.Drawing.Point(300, 130);
            this.lblReportMostService.Name = "lblReportMostService";
            this.lblReportMostService.Size = new System.Drawing.Size(124, 15);
            this.lblReportMostService.TabIndex = 10;
            this.lblReportMostService.Text = "Most Availed Service:";
            // 
            // txtReportMostService
            // 
            this.txtReportMostService.BackColor = System.Drawing.Color.White;
            this.txtReportMostService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportMostService.Location = new System.Drawing.Point(300, 150);
            this.txtReportMostService.Name = "txtReportMostService";
            this.txtReportMostService.ReadOnly = true;
            this.txtReportMostService.Size = new System.Drawing.Size(180, 23);
            this.txtReportMostService.TabIndex = 11;
            this.txtReportMostService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportHighestDay
            // 
            this.lblReportHighestDay.AutoSize = true;
            this.lblReportHighestDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportHighestDay.Location = new System.Drawing.Point(15, 185);
            this.lblReportHighestDay.Name = "lblReportHighestDay";
            this.lblReportHighestDay.Size = new System.Drawing.Size(125, 15);
            this.lblReportHighestDay.TabIndex = 12;
            this.lblReportHighestDay.Text = "Highest Revenue Day:";
            // 
            // txtReportHighestDay
            // 
            this.txtReportHighestDay.BackColor = System.Drawing.Color.White;
            this.txtReportHighestDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportHighestDay.Location = new System.Drawing.Point(15, 205);
            this.txtReportHighestDay.Name = "txtReportHighestDay";
            this.txtReportHighestDay.ReadOnly = true;
            this.txtReportHighestDay.Size = new System.Drawing.Size(180, 23);
            this.txtReportHighestDay.TabIndex = 13;
            this.txtReportHighestDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportTotalExpenses
            // 
            this.lblReportTotalExpenses.AutoSize = true;
            this.lblReportTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportTotalExpenses.Location = new System.Drawing.Point(15, 240);
            this.lblReportTotalExpenses.Name = "lblReportTotalExpenses";
            this.lblReportTotalExpenses.Size = new System.Drawing.Size(91, 15);
            this.lblReportTotalExpenses.TabIndex = 14;
            this.lblReportTotalExpenses.Text = "Total Expenses:";
            // 
            // txtReportTotalExpenses
            // 
            this.txtReportTotalExpenses.BackColor = System.Drawing.Color.White;
            this.txtReportTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportTotalExpenses.Location = new System.Drawing.Point(15, 260);
            this.txtReportTotalExpenses.Name = "txtReportTotalExpenses";
            this.txtReportTotalExpenses.ReadOnly = true;
            this.txtReportTotalExpenses.Size = new System.Drawing.Size(180, 23);
            this.txtReportTotalExpenses.TabIndex = 15;
            this.txtReportTotalExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReportNetProfit
            // 
            this.lblReportNetProfit.AutoSize = true;
            this.lblReportNetProfit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReportNetProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReportNetProfit.Location = new System.Drawing.Point(300, 240);
            this.lblReportNetProfit.Name = "lblReportNetProfit";
            this.lblReportNetProfit.Size = new System.Drawing.Size(112, 15);
            this.lblReportNetProfit.TabIndex = 16;
            this.lblReportNetProfit.Text = "Net Profit (Owner):";
            // 
            // txtReportNetProfit
            // 
            this.txtReportNetProfit.BackColor = System.Drawing.Color.White;
            this.txtReportNetProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportNetProfit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtReportNetProfit.Location = new System.Drawing.Point(300, 260);
            this.txtReportNetProfit.Name = "txtReportNetProfit";
            this.txtReportNetProfit.ReadOnly = true;
            this.txtReportNetProfit.Size = new System.Drawing.Size(180, 23);
            this.txtReportNetProfit.TabIndex = 17;
            this.txtReportNetProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 711);
            this.Controls.Add(this.btnYearlyToggle);
            this.Controls.Add(this.btnMonthlyToggle);
            this.Controls.Add(this.lsvMonthlyEntries);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dtpReportDate);
            this.Controls.Add(this.lblSelectMonth);
            this.Name = "ReportForm";
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
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.ListView lsvMonthlyEntries;
        private System.Windows.Forms.Button btnMonthlyToggle;
        private System.Windows.Forms.Button btnYearlyToggle;
        private System.Windows.Forms.Label lblReportTotalRevenue;
        private System.Windows.Forms.TextBox txtReportTotalRevenue;
        private System.Windows.Forms.Label lblReportOwnerShare;
        private System.Windows.Forms.TextBox txtReportOwnerShare;
        private System.Windows.Forms.Label lblReportEmpShare;
        private System.Windows.Forms.TextBox txtReportEmpShare;
        private System.Windows.Forms.Label lblReportTotalWashes;
        private System.Windows.Forms.TextBox txtReportTotalWashes;
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
    }
}
