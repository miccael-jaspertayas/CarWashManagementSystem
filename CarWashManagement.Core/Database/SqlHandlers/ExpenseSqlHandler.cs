using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CarWashManagement.Core.Database;

namespace CarWashManagement.Core.Database.SqlHandlers
{
    public class ExpenseSqlHandler : ISqlHandler<Expense>
    {
        public List<Expense> Load()
        {
            List<Expense> expenses = new List<Expense>();
            
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, Date, Description, Amount FROM Expenses ORDER BY Date DESC";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            expenses.Add(new Expense
                            {
                                Id = Guid.Parse(reader["Id"].ToString()),
                                Date = Convert.ToDateTime(reader["Date"]),
                                Description = reader["Description"].ToString(),
                                Amount = Convert.ToDecimal(reader["Amount"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading expenses from database: {ex.Message}", ex);
            }
            
            return expenses;
        }

        public void Save(List<Expense> expenses)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    // Delete all existing expenses
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Expenses", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                    
                    // Insert all expenses
                    foreach (Expense expense in expenses)
                    {
                        string insertQuery = @"
                            INSERT INTO Expenses (Id, Date, Description, Amount)
                            VALUES (@Id, @Date, @Description, @Amount)";
                        
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", expense.Id);
                            cmd.Parameters.AddWithValue("@Date", expense.Date);
                            cmd.Parameters.AddWithValue("@Description", expense.Description);
                            cmd.Parameters.AddWithValue("@Amount", expense.Amount);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving expenses to database: {ex.Message}", ex);
            }
        }
    }
}

