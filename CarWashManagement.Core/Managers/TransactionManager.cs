using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWashManagement.Core.FileHandlers;

namespace CarWashManagement.Core.Managers
{
    public class TransactionManager
    {
        private readonly TransactionFileHandler txnFileHandler;
        private List<Transaction> transactions;
        private int nextTransactionNumber;

        public TransactionManager(TransactionFileHandler txnFileHandler)
        {
            this.txnFileHandler = txnFileHandler;
            transactions = txnFileHandler.LoadAllTransactions();

            // Determine the next transaction number based on existing transactions.
            if (transactions.Count == 0)
            {
                nextTransactionNumber = 1; // Start from 1 if no transactions exist.
            } else
            {
                // Get the ID of the last transaction.
                string lastID = transactions.Last().ID;
                int lastNumber = int.Parse(lastID.Substring(3));
                nextTransactionNumber = lastNumber + 1;
            }
        }

        // Method to create a new transaction object and saves it to the transactions.txt file.
        public Transaction CreateTransaction(string employeeName, Vehicle vehicle, List<Service> services)
        {
            Transaction txn = new Transaction
            {
                ID = $"TXN{nextTransactionNumber:D6}",
                Timestamp = DateTime.Now,
                EmployeeName = employeeName,
                VehicleType = vehicle.Type,
                BaseFee = vehicle.BaseFee,
                OwnerShare = vehicle.OwnerShare,
                EmployeeShare = vehicle.EmployeeShare,
                IsPaid = false, // Initially mark as unpaid.
                AdditionalServices = services
            };

            // Calculate total amount of additional services availed by the customer.
            decimal servicesTotal = services.Sum(s => s.Fee); 
            txn.TotalAmount = txn.BaseFee + servicesTotal;  

            // Save transaction to file.
            txnFileHandler.SaveTransaction(txn);

            // Add to in-memory list.
            transactions.Add(txn);

            return txn;
        }

        public List<Transaction> GetTodaysTransactions()
        {
            return transactions
                .Where(txn => txn.Timestamp.Date == DateTime.Today)
                .OrderByDescending(txn => txn.Timestamp)
                .ToList();
        }
    }
}
