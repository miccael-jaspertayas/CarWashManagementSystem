using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CarWashManagement.Core.Database;

namespace CarWashManagement.Core.Database.SqlHandlers
{
    public class VehicleSqlHandler : ISqlHandler<Vehicle>
    {
        public List<Vehicle> Load()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Type, BaseFee, OwnerShare, EmployeeShare FROM Vehicles";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vehicles.Add(new Vehicle
                            {
                                Type = reader["Type"].ToString(),
                                BaseFee = Convert.ToDecimal(reader["BaseFee"]),
                                OwnerShare = Convert.ToDecimal(reader["OwnerShare"]),
                                EmployeeShare = Convert.ToDecimal(reader["EmployeeShare"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading vehicles from database: {ex.Message}", ex);
            }
            
            return vehicles;
        }

        public void Save(List<Vehicle> vehicles)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    // Delete all existing vehicles
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Vehicles", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                    
                    // Insert all vehicles
                    foreach (Vehicle vehicle in vehicles)
                    {
                        string insertQuery = @"
                            INSERT INTO Vehicles (Type, BaseFee, OwnerShare, EmployeeShare)
                            VALUES (@Type, @BaseFee, @OwnerShare, @EmployeeShare)";
                        
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Type", vehicle.Type);
                            cmd.Parameters.AddWithValue("@BaseFee", vehicle.BaseFee);
                            cmd.Parameters.AddWithValue("@OwnerShare", vehicle.OwnerShare);
                            cmd.Parameters.AddWithValue("@EmployeeShare", vehicle.EmployeeShare);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving vehicles to database: {ex.Message}", ex);
            }
        }
    }
}

