using CarWashManagement.Core.Database.SqlHandlers;
using CarWashManagement.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.Core.Managers
{
    public class ExpenseManager
    {
        private readonly ISqlHandler<Expense> expenseSqlHandler;
        private readonly AuditSqlHandler auditSqlHandler;
        private List<Expense> expenses;

        public ExpenseManager(ISqlHandler<Expense> expenseSqlHandler, AuditSqlHandler auditSqlHandler)
        {
            // Ensure database exists
            DatabaseConnection.EnsureDatabaseExists();
            
            this.expenseSqlHandler = expenseSqlHandler;
            this.auditSqlHandler = auditSqlHandler;
            expenses = expenseSqlHandler.Load(); // Load existing expenses from database
        }

        // Method to create a new expense and save it to the database
        public void CreateExpense(DateTime date, string description, decimal amount, string loggedInUsername)
        {
            Expense newExpense = new Expense
            {
                Date = date,
                Description = description,
                Amount = amount
            };

            expenses.Add(newExpense);
            expenseSqlHandler.Save(expenses); // Save updated expenses list to database

            auditSqlHandler.LogEvent($"EXPENSE: User '{loggedInUsername}' added expense '{description}' for {amount:N2} (Date: {date:yyyy-MM-dd}).");
        }

        // Method to get all expenses for a specific month.
        public List<Expense> GetExpensesForMonth(int year, int month)
        {
            return expenses
                .Where(e => e.Date.Year == year && e.Date.Month == month)
                .ToList();
        }

        // Method to get all expenses for a specific year.
        public List<Expense> GetExpensesForYear(int year)
        {
            return expenses
                .Where(e => e.Date.Year == year)
                .ToList();
        }

        // Method to get all expenses
        public List<Expense> GetAllExpenses()
        {
            return expenses
                .OrderByDescending(e => e.Date)
                .ToList();
        }
    }
}
