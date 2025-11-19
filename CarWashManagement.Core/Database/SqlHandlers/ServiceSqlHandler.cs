using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CarWashManagement.Core.Database;
using CarWashManagement.Core.Enums;

namespace CarWashManagement.Core.Database.SqlHandlers
{
    public class ServiceSqlHandler : ISqlHandler<Service>
    {
        public List<Service> Load()
        {
            List<Service> services = new List<Service>();
            
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Name, Fee, PricingType, Multiplier FROM Services";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            services.Add(new Service
                            {
                                Name = reader["Name"].ToString(),
                                Fee = Convert.ToDecimal(reader["Fee"]),
                                PricingType = (ServicePricingType)Enum.Parse(typeof(ServicePricingType), reader["PricingType"].ToString()),
                                Multiplier = Convert.ToInt32(reader["Multiplier"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading services from database: {ex.Message}", ex);
            }
            
            return services;
        }

        public void Save(List<Service> services)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    // Delete all existing services
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Services", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                    
                    // Insert all services
                    foreach (Service service in services)
                    {
                        string insertQuery = @"
                            INSERT INTO Services (Name, Fee, PricingType, Multiplier)
                            VALUES (@Name, @Fee, @PricingType, @Multiplier)";
                        
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", service.Name);
                            cmd.Parameters.AddWithValue("@Fee", service.Fee);
                            cmd.Parameters.AddWithValue("@PricingType", service.PricingType.ToString());
                            cmd.Parameters.AddWithValue("@Multiplier", service.Multiplier);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving services to database: {ex.Message}", ex);
            }
        }
    }
}

