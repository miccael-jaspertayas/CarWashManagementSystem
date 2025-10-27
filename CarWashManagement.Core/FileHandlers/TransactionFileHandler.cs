using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWashManagement.Core.Enums;

namespace CarWashManagement.Core.FileHandlers
{
    // File handler class for managing transaction data in transactions.txt file.
    // Did not implement IFileHandler<Transaction> as transactions requires custom logic.
    public class TransactionFileHandler
    {
        private readonly string filePath = FilePathManager.TransactionsFilePath;

        // Method to save a single transaction by appending it to the transactions.txt file.
        public void SaveTransaction(Transaction txn)
        {
            try
            {
                // Simplify the list of services into a single string.
                // Example: "Wax (200.00), Buffing (400.00)".
                string servicesString = string.Join(",",
                    txn.AdditionalServices.Select(s => $"{s.Name} ({s.Fee}) [{s.PricingType}] {{{s.Multiplier}}}"));

                string line = string.Join("|", 
                    txn.ID,
                    txn.Timestamp.ToString("O"), // Converts timestamp into string in ISO 8601 format.
                    txn.VehicleType,
                    txn.EmployeeName,
                    txn.BaseFee.ToString(),
                    txn.OwnerShare.ToString(),
                    txn.EmployeeShare.ToString(),
                    txn.TotalAmount.ToString(),
                    txn.IsPaid.ToString(),
                    servicesString);

                File.AppendAllText(filePath, line + "\n");
            } catch (Exception ex)
            {
                Console.WriteLine($"Could not write to transactions file. Error: {ex.Message}");
            }
        }
        
        public List<Transaction> LoadAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                return transactions; // Return an empty list.

            } else
            {
                // Read all lines from the transactions.txt.
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    try
                    {
                        // Split the line by '|' delimiter.
                        string[] parts = line.Split('|');

                        // Make sure that it has all 10 properties.
                        if (parts.Length == 10)
                        {
                            // Create a new Transaction object.
                            Transaction txn = new Transaction
                            {
                                ID = parts[0],
                                Timestamp = DateTime.Parse(parts[1]),
                                VehicleType = parts[2],
                                EmployeeName = parts[3],
                                BaseFee = decimal.Parse(parts[4]),
                                OwnerShare = decimal.Parse(parts[5]),
                                EmployeeShare = decimal.Parse(parts[6]),
                                TotalAmount = decimal.Parse(parts[7]),
                                IsPaid = bool.Parse(parts[8]),
                                AdditionalServices = ParseServices(parts[9])
                            };
                            transactions.Add(txn);
                        }
                    } catch (Exception ex)
                    {
                        Console.WriteLine($"Error parsing transaction file line: {line}.\nError: {ex.Message}");
                    }
                }
                return transactions;
            }
        }

        // Method to parse the services string into a list of Service objects.
        private List<Service> ParseServices(string servicesString)
        {
            List<Service> services = new List<Service>();

            if (string.IsNullOrWhiteSpace(servicesString))
            {
                return services;
            }

            string[] serviceParts = servicesString.Split(',');

            foreach (string servicePart in serviceParts)
            {
                try
                {
                    //                         NAME |  FEE  | PRICING TYPE | MULTIPLIER
                    // Example servicePart: "Buffing (200.00) [ManualInput] {1}"

                    int feeStart = servicePart.LastIndexOf('(');
                    int feeEnd = servicePart.LastIndexOf(')');

                    int typeStart = servicePart.LastIndexOf('[');
                    int typeEnd = servicePart.LastIndexOf(']');

                    int multiplierStart = servicePart.LastIndexOf('{');
                    int multiplierEnd = servicePart.LastIndexOf('}');

                    // Validate indices before extracting substrings.
                    if ((feeStart > 0 && feeEnd > feeStart) && 
                        (typeStart > feeEnd && typeEnd > typeStart) &&
                        (multiplierStart > typeEnd && multiplierEnd > multiplierStart))
                    {
                        // Extract the substrings using the indeces of parenthesis, brackets, and curly braces.
                        string name = servicePart.Substring(0, feeStart).Trim();
                        string feeString = servicePart.Substring(feeStart + 1, feeEnd - feeStart - 1).Trim();
                        string typeString = servicePart.Substring(typeStart + 1, typeEnd - typeStart - 1).Trim();
                        string multiplierString = servicePart.Substring(multiplierStart + 1, multiplierEnd - multiplierStart - 1).Trim();

                        // Create the Service object.
                        Service service = new Service
                        {
                            Name = name,
                            Fee = decimal.Parse(feeString),
                            PricingType = (ServicePricingType)Enum.Parse(typeof(ServicePricingType), typeString),
                            Multiplier = int.Parse(multiplierString)
                        };

                        services.Add(service);
                    }

                } catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing service from string: {servicePart}. Error: {ex.Message}");
                }
            }
            return services;
        }
    }
}
