using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CarWashManagement.Core.Database;
using CarWashManagement.Core.Enums;

namespace CarWashManagement.Core.Database.SqlHandlers
{
    public class TransactionSqlHandler
    {
        public void SaveTransaction(Transaction txn)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    // Insert transaction
                    string insertTransactionQuery = @"
                        INSERT INTO Transactions (ID, Timestamp, VehicleType, EmployeeName, BaseFee, ServiceTotal, 
                                                  OwnerShare, EmployeeShare, TotalAmount, IsPaid, WashStatus, DiscountPercentage)
                        VALUES (@ID, @Timestamp, @VehicleType, @EmployeeName, @BaseFee, @ServiceTotal, 
                                @OwnerShare, @EmployeeShare, @TotalAmount, @IsPaid, @WashStatus, @DiscountPercentage)";
                    
                    using (SqlCommand cmd = new SqlCommand(insertTransactionQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", txn.ID);
                        cmd.Parameters.AddWithValue("@Timestamp", txn.Timestamp);
                        cmd.Parameters.AddWithValue("@VehicleType", txn.VehicleType);
                        cmd.Parameters.AddWithValue("@EmployeeName", txn.EmployeeName);
                        cmd.Parameters.AddWithValue("@BaseFee", txn.BaseFee);
                        cmd.Parameters.AddWithValue("@ServiceTotal", txn.ServiceTotal);
                        cmd.Parameters.AddWithValue("@OwnerShare", txn.OwnerShare);
                        cmd.Parameters.AddWithValue("@EmployeeShare", txn.EmployeeShare);
                        cmd.Parameters.AddWithValue("@TotalAmount", txn.TotalAmount);
                        cmd.Parameters.AddWithValue("@IsPaid", txn.IsPaid);
                        cmd.Parameters.AddWithValue("@WashStatus", txn.WashStatus);
                        cmd.Parameters.AddWithValue("@DiscountPercentage", txn.DiscountPercentage);
                        cmd.ExecuteNonQuery();
                    }
                    
                    // Insert transaction services
                    foreach (Service service in txn.AdditionalServices)
                    {
                        string insertServiceQuery = @"
                            INSERT INTO TransactionServices (TransactionID, ServiceName, ServiceFee, PricingType, Multiplier)
                            VALUES (@TransactionID, @ServiceName, @ServiceFee, @PricingType, @Multiplier)";
                        
                        using (SqlCommand cmd = new SqlCommand(insertServiceQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@TransactionID", txn.ID);
                            cmd.Parameters.AddWithValue("@ServiceName", service.Name);
                            cmd.Parameters.AddWithValue("@ServiceFee", service.Fee);
                            cmd.Parameters.AddWithValue("@PricingType", service.PricingType.ToString());
                            cmd.Parameters.AddWithValue("@Multiplier", service.Multiplier);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving transaction to database: {ex.Message}", ex);
            }
        }

        public void SaveAllTransactions(List<Transaction> transactions)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    // Delete all existing transactions and their services (CASCADE will handle TransactionServices)
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Transactions", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                    
                    // Insert all transactions
                    foreach (Transaction txn in transactions)
                    {
                        SaveTransaction(txn);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving all transactions to database: {ex.Message}", ex);
            }
        }

        public List<Transaction> LoadAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    // Load all transactions
                    string query = @"
                        SELECT ID, Timestamp, VehicleType, EmployeeName, BaseFee, ServiceTotal, 
                               OwnerShare, EmployeeShare, TotalAmount, IsPaid, WashStatus, DiscountPercentage
                        FROM Transactions
                        ORDER BY Timestamp DESC";
                    
                    Dictionary<string, Transaction> transactionDict = new Dictionary<string, Transaction>();
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction txn = new Transaction
                            {
                                ID = reader["ID"].ToString(),
                                Timestamp = Convert.ToDateTime(reader["Timestamp"]),
                                VehicleType = reader["VehicleType"].ToString(),
                                EmployeeName = reader["EmployeeName"].ToString(),
                                BaseFee = Convert.ToDecimal(reader["BaseFee"]),
                                ServiceTotal = Convert.ToDecimal(reader["ServiceTotal"]),
                                OwnerShare = Convert.ToDecimal(reader["OwnerShare"]),
                                EmployeeShare = Convert.ToDecimal(reader["EmployeeShare"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                IsPaid = Convert.ToBoolean(reader["IsPaid"]),
                                WashStatus = reader["WashStatus"].ToString(),
                                DiscountPercentage = Convert.ToDecimal(reader["DiscountPercentage"]),
                                AdditionalServices = new List<Service>()
                            };
                            
                            transactionDict[txn.ID] = txn;
                            transactions.Add(txn);
                        }
                    }
                    
                    // Load services for each transaction
                    if (transactionDict.Count > 0)
                    {
                        foreach (string txnId in transactionDict.Keys)
                        {
                            string serviceQuery = @"
                                SELECT TransactionID, ServiceName, ServiceFee, PricingType, Multiplier
                                FROM TransactionServices
                                WHERE TransactionID = @TransactionID";
                            
                            using (SqlCommand cmd = new SqlCommand(serviceQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@TransactionID", txnId);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        transactionDict[txnId].AdditionalServices.Add(new Service
                                        {
                                            Name = reader["ServiceName"].ToString(),
                                            Fee = Convert.ToDecimal(reader["ServiceFee"]),
                                            PricingType = (ServicePricingType)Enum.Parse(typeof(ServicePricingType), reader["PricingType"].ToString()),
                                            Multiplier = Convert.ToInt32(reader["Multiplier"])
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading transactions from database: {ex.Message}", ex);
            }
            
            return transactions;
        }
    }
}

