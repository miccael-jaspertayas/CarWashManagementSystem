using System;
using System.Data.SqlClient;
using CarWashManagement.Core.Database;

namespace CarWashManagement.Core.Database.SqlHandlers
{
    public class AuditSqlHandler
    {
        public void LogEvent(string message)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO AuditLog (Timestamp, Message) VALUES (@Timestamp, @Message)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Message", message);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log to console if database logging fails
                Console.WriteLine($"Could not write to audit log. Error: {ex.Message}");
            }
        }
    }
}

