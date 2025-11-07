using CarWashManagement.Core;
using CarWashManagement.Core.FileHandlers;
using CarWashManagement.Core.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashManagement.UI
{
    // Form that allows admin to manage expenses.
    public class ExpenseManagementForm : BaseForm
    {
        private ListView lsvExpenses;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblDate;
        private DateTimePicker dtpExpenseDate;
        private Button btnAddExpense;

        private readonly User loggedInUser;

        private readonly ExpenseManager expenseManager;

        public ExpenseManagementForm(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;

            expenseManager = new ExpenseManager(
                new ExpenseFileHandler(),
                new AuditFileHandler()
                );

            SetUpControls();
            LoadExpenseList();
        }

        // Method to set up the form and its controls.
        public void SetUpControls()
        {
            Text = "Expense Management";
            Size = new Size(500, 420);

            // --- Expense List View ---
            lsvExpenses = new ListView
            {
                Location = new Point(15, 15),
                Size = new Size(450, 200),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };
            lsvExpenses.Columns.Add("Date", 100);
            lsvExpenses.Columns.Add("Description", 230);
            lsvExpenses.Columns.Add("Amount", 100, HorizontalAlignment.Right);
            Controls.Add(lsvExpenses);

            int formY = 230;

            // --- Date ---
            lblDate = new Label
            {
                Text = "Date:",
                Location = new Point(15, formY),
                AutoSize = true
            };
            Controls.Add(lblDate);

            dtpExpenseDate = new DateTimePicker
            {
                Location = new Point(15, formY + 20),
                Size = new Size(200, 23),
                Format = DateTimePickerFormat.Short
            };
            Controls.Add(dtpExpenseDate);

            // --- Description ---
            lblDescription = new Label
            {
                Text = "Description:",
                Location = new Point(15, formY + 50),
                AutoSize = true
            };
            Controls.Add(lblDescription);

            txtDescription = new TextBox
            {
                Location = new Point(15, formY + 70),
                Size = new Size(300, 23)
            };
            Controls.Add(txtDescription);

            // --- Amount ---
            lblAmount = new Label
            {
                Text = "Amount:",
                Location = new Point(330, formY + 50),
                AutoSize = true
            };
            Controls.Add(lblAmount);

            txtAmount = new TextBox
            {
                Location = new Point(330, formY + 70),
                Size = new Size(135, 23),
                TextAlign = HorizontalAlignment.Right
            };
            Controls.Add(txtAmount);

            // --- Add Expense Button ---
            btnAddExpense = new Button
            {
                Text = "Add Expense",
                Location = new Point(330, formY + 110),
                Size = new Size(135, 30)
            };
            btnAddExpense.Click += btnAddExpense_Click;
            Controls.Add(btnAddExpense);
        }

        // Load all expenses from the manager into the ListView.
        private void LoadExpenseList()
        {
            lsvExpenses.Items.Clear();

            List<Expense> expenses = expenseManager.GetAllExpenses();

            foreach (Expense expense in expenses)
            {
                ListViewItem row = new ListViewItem(expense.Date.ToString("yyyy-MM-dd"));
                row.SubItems.Add(expense.Description);
                row.SubItems.Add(expense.Amount.ToString("C", CultureInfo.GetCultureInfo("en-PH"))); // Format as currency (PHP)
                lsvExpenses.Items.Add(row);
            }
        }

        // Event handler for adding a new expense.
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text.Trim();
            string amountStr = txtAmount.Text.Trim();
            DateTime date = dtpExpenseDate.Value;

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter a description for the expense.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountStr, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount for the expense.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the manager to create and save the expense.
            expenseManager.CreateExpense(date, description, amount, loggedInUser.Username);

            MessageBox.Show("Expense added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExpenseList();

            // Clear input fields.
            txtDescription.Clear();
            txtAmount.Clear();
            dtpExpenseDate.Value = DateTime.Now;
        }
    }
}
