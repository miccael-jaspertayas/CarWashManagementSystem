using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using CarWashManagement.Core;
using CarWashManagement.Core.Managers;
using CarWashManagement.Core.FileHandlers;
using System.Globalization;

namespace CarWashManagement.UI
{
    public enum ReportMode { Monthly, Yearly }
    
    // Form to generate report based on the inputted month-year.
    public class ReportForm : BaseForm
    {
        private Label lblSelectMonth;
        private DateTimePicker dtpReportDate;
        private Button btnGenerateReport;
        private Panel pnlReport;

        private Label lblEntries;
        private ListView lsvMonthlyEntries;

        private Button btnMonthlyToggle;
        private Button btnYearlyToggle;
        private ReportMode currentReportMode = ReportMode.Monthly; // Default report mode.

        private Label lblReportTotalRevenue;
        private TextBox txtReportTotalRevenue;
        private Label lblReportOwnerShare;
        private TextBox txtReportOwnerShare;
        private Label lblReportEmpShare;
        private TextBox txtReportEmpShare;
        private Label lblReportTotalWashes;
        private TextBox txtReportTotalWashes;
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

        private readonly TransactionManager transactionManager;
        private readonly ExpenseManager expenseManager;

        public ReportForm()
        {
            transactionManager = new TransactionManager(new TransactionFileHandler(), new AuditFileHandler());
            expenseManager = new ExpenseManager(new ExpenseFileHandler(), new AuditFileHandler());

            SetUpControls();
        }

        // Method to set up all the controls for this form.
        private void SetUpControls()
        {
            Text = "Monthly/Yearly Report Dashboard";
            Size = new Size(640, 750);

            // --- Month and Year Picker ---
            lblSelectMonth = new Label
            {
                Text = "Select Month:",
                Location = new Point(15, 15),
                AutoSize = true
            };
            Controls.Add(lblSelectMonth);

            dtpReportDate = new DateTimePicker
            {
                Location = new Point(110, 12),
                Size = new Size(150, 23),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "MMMM yyyy" // January 2025
            };
            Controls.Add(dtpReportDate);

            // --- Generate Button ---
            btnGenerateReport = new Button 
            { 
                Text = "Generate", 
                Location = new Point(270, 10), 
                Size = new Size(80, 30) 
            };
            btnGenerateReport.Click += btnGenerateReport_Click;
            Controls.Add(btnGenerateReport);


            // --- Monthly Toggle Button ---
            btnMonthlyToggle = new Button
            {
                Text = "Monthly",
                Location = new Point(450, 10),
                Size = new Size(75, 30),
                BackColor = Color.LightGray
            };
            btnMonthlyToggle.Click += btnMonthlyToggle_Click;
            Controls.Add(btnMonthlyToggle);


            // --- Yearly Toggle Button ---
            btnYearlyToggle = new Button
            {
                Text = "Yearly",
                Location = new Point(530, 10),
                Size = new Size(75, 30),
            };
            btnYearlyToggle.Click += btnYearlyToggle_Click;
            Controls.Add(btnYearlyToggle);

            // - - - - - Report Panel - - - - -
            pnlReport = new Panel
            {
                Location = new Point(15, 50),
                Size = new Size(590, 320),
                BorderStyle = BorderStyle.Fixed3D
            };
            this.Controls.Add(pnlReport);

            int col1X = 15;
            int col2X = 300;
            int currentY = 20;

            // --- Total Revenue ---
            lblReportTotalRevenue = new Label 
            { 
                Text = "Total Revenue:", 
                Location = new Point(col1X, currentY), 
                Font = new Font(Font, FontStyle.Bold), 
                AutoSize = true 
            };
            
            txtReportTotalRevenue = new TextBox 
            { 
                Location = new Point(col1X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                Font = new Font(Font, FontStyle.Bold), 
                TextAlign = HorizontalAlignment.Right 
            };

            // --- Total Washes ---
            lblReportTotalWashes = new Label 
            { 
                Text = "Total Washes:", 
                Location = new Point(col2X, currentY), 
                AutoSize = true 
            };

            txtReportTotalWashes = new TextBox 
            { 
                Location = new Point(col2X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                TextAlign = HorizontalAlignment.Right 
            };
            
            currentY += 55;

            // --- Total Owner Share ---
            lblReportOwnerShare = new Label 
            { 
                Text = "Total Owner Share:", 
                Location = new Point(col1X, currentY), 
                AutoSize = true 
            };
            txtReportOwnerShare = new TextBox 
            { 
                Location = new Point(col1X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                TextAlign = HorizontalAlignment.Right 
            };

            // --- Total Employee Share ---
            lblReportEmpShare = new Label 
            { 
                Text = "Total Employee Share:", 
                Location = new Point(col2X, currentY), 
                AutoSize = true 
            };

            txtReportEmpShare = new TextBox 
            { 
                Location = new Point(col2X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                TextAlign = HorizontalAlignment.Right 
            };

            currentY += 55;

            // --- Most Washed Vehicle ---
            lblReportMostWashed = new Label 
            { 
                Text = "Most Washed Vehicle:", 
                Location = new Point(col1X, currentY), 
                AutoSize = true 
            };

            txtReportMostWashed = new TextBox 
            { 
                Location = new Point(col1X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                TextAlign = HorizontalAlignment.Right 
            };

            // --- Most Availed Service ---
            lblReportMostService = new Label 
            { 
                Text = "Most Availed Service:", 
                Location = new Point(col2X, currentY), 
                AutoSize = true 
            };

            txtReportMostService = new TextBox 
            { 
                Location = new Point(col2X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                TextAlign = HorizontalAlignment.Right 
            };
            
            currentY += 55;

            // --- Highest Revenue Day ---
            lblReportHighestDay = new Label 
            { 
                Text = "Highest Revenue Day:", 
                Location = new Point(col1X, currentY), 
                AutoSize = true 
            };

            txtReportHighestDay = new TextBox 
            { 
                Location = new Point(col1X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                TextAlign = HorizontalAlignment.Right 
            };
            
            currentY += 55;

            // --- Total Expenses ---
            lblReportTotalExpenses = new Label 
            { 
                Text = "Total Expenses:", 
                Location = new Point(col1X, currentY), 
                AutoSize = true 
            };

            txtReportTotalExpenses = new TextBox 
            { 
                Location = new Point(col1X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                TextAlign = HorizontalAlignment.Right 
            };

            // --- Net Profit (Owner) ---
            lblReportNetProfit = new Label 
            { 
                Text = "Net Profit (Owner):", 
                Location = new Point(col2X, currentY), 
                Font = new Font(this.Font, FontStyle.Bold), 
                AutoSize = true 
            };

            txtReportNetProfit = new TextBox 
            { 
                Location = new Point(col2X, currentY + 20), 
                Size = new Size(180, 23), 
                ReadOnly = true, 
                Font = new Font(this.Font, FontStyle.Bold), 
                TextAlign = HorizontalAlignment.Right 
            };

            // Add all controls to the report panel.
            pnlReport.Controls.AddRange(new Control[] {
                lblReportTotalRevenue, txtReportTotalRevenue, lblReportTotalWashes, txtReportTotalWashes,
                lblReportOwnerShare, txtReportOwnerShare, lblReportEmpShare, txtReportEmpShare,
                lblReportMostWashed, txtReportMostWashed, lblReportMostService, txtReportMostService,
                lblReportHighestDay, txtReportHighestDay, lblReportTotalExpenses, txtReportTotalExpenses,
                lblReportNetProfit, txtReportNetProfit});

            // --- Entries ListView ---
            lblEntries = new Label
            {
                Text = "Entries",
                Location = new Point(15, 385),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            Controls.Add(lblEntries);

            lsvMonthlyEntries = new ListView
            {
                Location = new Point(15, 410),
                Size = new Size(590, 285),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };
            lsvMonthlyEntries.Columns.Add("Time", 70);
            lsvMonthlyEntries.Columns.Add("Vehicle", 90);
            lsvMonthlyEntries.Columns.Add("Employee", 100);
            lsvMonthlyEntries.Columns.Add("Owner Share", 100, HorizontalAlignment.Right);
            lsvMonthlyEntries.Columns.Add("Employee Share", 100, HorizontalAlignment.Right);
            lsvMonthlyEntries.Columns.Add("Payment Status", 100);
            Controls.Add(lsvMonthlyEntries);

        }

        // Event handler when the monthly toggle button is clicked.
        private void btnMonthlyToggle_Click(object sender, EventArgs e)
        {
            currentReportMode = ReportMode.Monthly;
            lblSelectMonth.Text = "Select Month:";
            dtpReportDate.CustomFormat = "MMMM yyyy";

            btnMonthlyToggle.BackColor = Color.LightGray;
            btnYearlyToggle.BackColor = SystemColors.Control;

            // Clear all textboxes in the report panel.
            foreach (Control ctrl in pnlReport.Controls)
            {
                if (ctrl is TextBox txt) { txt.Clear(); }
            }
            // Clear entry list.
            lsvMonthlyEntries.Items.Clear();
            lsvMonthlyEntries.Groups.Clear();
        }

        // Event handler when the monthly toggle button is clicked.
        private void btnYearlyToggle_Click(object sender, EventArgs e)
        {
            currentReportMode = ReportMode.Yearly;
            lblSelectMonth.Text = "Select Year:";
            dtpReportDate.CustomFormat = "yyyy";

            btnYearlyToggle.BackColor = Color.LightGray;
            btnMonthlyToggle.BackColor = SystemColors.Control;

            // Clear all textboxes in the report panel.
            foreach (Control ctrl in pnlReport.Controls)
            {
                if (ctrl is TextBox txt) { txt.Clear(); }
            }
            // Clear entry list.
            lsvMonthlyEntries.Items.Clear();
            lsvMonthlyEntries.Groups.Clear();
        }

        // Event handler when the Generate Button is clicked.
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Run the correct report based on the report mode.
            if (currentReportMode == ReportMode.Monthly)
            {
                GenerateMonthlyReport();
            }
            else
            {
                GenerateYearlyReport();
            }
        }

        // Method to generate a monthly financial/statistic report.
        private void GenerateMonthlyReport()
        {
            DateTime selectedDate = dtpReportDate.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;

            // Get all transactions for the month.
            List<Transaction> transactions = transactionManager.GetTransactionsForMonth(year, month);

            // Get all Paid transactions for the month.
            List<Transaction> paidTransactions = transactions
                .Where(txn => txn.IsPaid)
                .ToList();

            // Get all expenses for the month.
            List<Expense> expenses = expenseManager.GetExpensesForMonth(year, month);

            // Calculations.
            decimal totalRevenue = paidTransactions.Sum(txn => txn.TotalAmount);
            decimal totalOwnerShare = paidTransactions.Sum(txn => txn.OwnerShare);
            decimal totalEmployeeShare = paidTransactions.Sum(txn => txn.EmployeeShare);
            int totalWashes = paidTransactions.Count();

            decimal totalExpenses = expenses.Sum(exp => exp.Amount);
            decimal netProfit = totalOwnerShare - totalExpenses;

            // Get Most Washed Vehicle.
            string mostWashed = "N/A";
            if (paidTransactions.Any())
            {
                mostWashed = paidTransactions
                    .GroupBy(txn => txn.VehicleType)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Get Most Availed service.
            var allServices = paidTransactions.SelectMany(txn => txn.AdditionalServices);
            string mostService = "N/A";
            if (paidTransactions.Any())
            {
                mostService = allServices
                    .GroupBy(s => s.Name)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Highest Revenue Day
            string highestDay = "N/A (0.00)";
            if (paidTransactions.Any())
            {
                var dailyRevenue = paidTransactions
                    .GroupBy(txn => txn.Timestamp.Date)
                    .Select(g => new { Date = g.Key, Total = g.Sum(txn => txn.TotalAmount) })
                    .OrderByDescending(d => d.Total)
                    .FirstOrDefault();

                if (dailyRevenue != null)
                {
                    highestDay = $"{dailyRevenue.Date:MMMM dd} ({dailyRevenue.Total:N2})";
                }
            }

            txtReportTotalRevenue.Text = totalRevenue.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportOwnerShare.Text = totalOwnerShare.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportEmpShare.Text = totalEmployeeShare.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportTotalWashes.Text = totalWashes.ToString();
            txtReportMostWashed.Text = mostWashed;
            txtReportMostService.Text = mostService;
            lblReportHighestDay.Text = "Highest Revenue Day:";
            txtReportHighestDay.Text = highestDay;
            txtReportTotalExpenses.Text = totalExpenses.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportNetProfit.Text = netProfit.ToString("C", CultureInfo.GetCultureInfo("en-PH"));

            lblEntries.Enabled = true;
            lsvMonthlyEntries.Enabled = true;

            // Group all transactions by date.
            var groupedByDay = transactions
                .OrderBy(txn => txn.Timestamp)
                .GroupBy(txn => txn.Timestamp.Date);

            foreach (var dayGroup in groupedByDay)
            {
                // Create a group for the day.
                string groupHeader = dayGroup.Key.ToString("MMMM dd, yyyy");
                ListViewGroup group = new ListViewGroup(groupHeader);
                lsvMonthlyEntries.Groups.Add(group);

                // Add each transaction from that day to the group.
                foreach (Transaction txn in dayGroup)
                {
                    ListViewItem row = new ListViewItem(txn.Timestamp.ToString("HH:mm"));
                    row.SubItems.Add(txn.VehicleType);
                    row.SubItems.Add(txn.EmployeeName);
                    row.SubItems.Add(txn.OwnerShare.ToString("C", CultureInfo.GetCultureInfo("en-PH")));
                    row.SubItems.Add(txn.EmployeeShare.ToString("C", CultureInfo.GetCultureInfo("en-PH")));
                    row.SubItems.Add(txn.IsPaid ? "Paid" : "Unpaid");
                    row.Group = group; // Assign the item to the day's group.

                    lsvMonthlyEntries.Items.Add(row);
                }
            }
        }

        // Method to generate yearly financial/statistic report.
        private void GenerateYearlyReport()
        {
            int year = dtpReportDate.Value.Year;

            List<Transaction> transactions = transactionManager.GetTransactionsForYear(year);
            List<Transaction> paidTransactions = transactions
                .Where(txn => txn.IsPaid)
                .ToList();
            List<Expense> expenses = expenseManager.GetExpensesForYear(year);

            // Calculations.
            decimal totalRevenue = paidTransactions.Sum(txn => txn.TotalAmount);
            decimal totalOwnerShare = paidTransactions.Sum(txn => txn.OwnerShare);
            decimal totalEmployeeShare = paidTransactions.Sum(txn => txn.EmployeeShare);
            int totalWashes = paidTransactions.Count();

            decimal totalExpenses = expenses.Sum(exp => exp.Amount);
            decimal netProfit = totalOwnerShare - totalExpenses;

            // Get Most Washed Vehicle.
            string mostWashed = "N/A";
            if (paidTransactions.Any())
            {
                mostWashed = paidTransactions
                    .GroupBy(txn => txn.VehicleType)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Get Most Availed service.
            var allServices = paidTransactions.SelectMany(txn => txn.AdditionalServices);
            string mostService = "N/A";
            if (paidTransactions.Any())
            {
                mostService = allServices
                    .GroupBy(s => s.Name)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Highest Revenue Day
            string highestMonth = "N/A (0.00)";
            if (paidTransactions.Any())
            {
                var monthlyRevenue = paidTransactions
                    .GroupBy(txn => txn.Timestamp.Month)
                    .Select(g => new { 
                        Month = g.Key, 
                        Total = g.Sum(txn => txn.TotalAmount) 
                    })
                    .OrderByDescending(m => m.Total)
                    .FirstOrDefault();

                if (monthlyRevenue != null)
                {
                    // Convert month number to month name.
                    string monthName = new DateTime(year, monthlyRevenue.Month, 1).ToString("MMMM");
                    highestMonth = $"{monthName} ({monthlyRevenue.Total:N2})";
                }
            }

            txtReportTotalRevenue.Text = totalRevenue.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportOwnerShare.Text = totalOwnerShare.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportEmpShare.Text = totalEmployeeShare.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportTotalWashes.Text = totalWashes.ToString();
            txtReportMostWashed.Text = mostWashed;
            txtReportMostService.Text = mostService;
            lblReportHighestDay.Text = "Highest Revenue Month:";
            txtReportHighestDay.Text = highestMonth;
            txtReportTotalExpenses.Text = totalExpenses.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            txtReportNetProfit.Text = netProfit.ToString("C", CultureInfo.GetCultureInfo("en-PH"));

            lblEntries.Enabled = false;
            lsvMonthlyEntries.Enabled = false;
        }
    }
}
