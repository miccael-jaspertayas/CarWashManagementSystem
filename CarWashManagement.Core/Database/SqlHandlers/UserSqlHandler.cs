using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CarWashManagement.Core.Database;

namespace CarWashManagement.Core.Database.SqlHandlers
{
    public class UserSqlHandler : ISqlHandler<User>
    {
        public List<User> Load()
        {
            List<User> users = new List<User>();
            
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Username, Password, Role, FullName, Status, FailedLoginAttempts FROM Users";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString().ToUpper(),
                                FullName = reader["FullName"].ToString(),
                                Status = reader["Status"].ToString().ToUpper(),
                                FailedLoginAttempts = Convert.ToInt32(reader["FailedLoginAttempts"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading users from database: {ex.Message}", ex);
            }
            
            return users;
        }

        public void Save(List<User> users)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    // Delete all existing users
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Users", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                    
                    // Insert all users
                    foreach (User user in users)
                    {
                        string insertQuery = @"
                            INSERT INTO Users (Username, Password, Role, FullName, Status, FailedLoginAttempts)
                            VALUES (@Username, @Password, @Role, @FullName, @Status, @FailedLoginAttempts)";
                        
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", user.Username);
                            cmd.Parameters.AddWithValue("@Password", user.Password);
                            cmd.Parameters.AddWithValue("@Role", user.Role.ToUpper());
                            cmd.Parameters.AddWithValue("@FullName", user.FullName);
                            cmd.Parameters.AddWithValue("@Status", user.Status.ToUpper());
                            cmd.Parameters.AddWithValue("@FailedLoginAttempts", user.FailedLoginAttempts);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving users to database: {ex.Message}", ex);
            }
        }
    }
}

