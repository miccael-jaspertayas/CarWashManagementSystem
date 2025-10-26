using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.Core
{
    public class Transaction
    {
        // Declaration of the transaction properties.
        public DateTime Timestamp { get; set; }
        public string VehicleType { get; set; }
        public string EmployeeName { get; set; }
        public double BaseFee { get; set; }
        public double OwnerShare { get; set; }
        public double EmployeeShare { get; set; }
        public double TotalAmount { get; set; }
        public bool IsPaid { get; set; }

        // A list to hold the additional services for a transaction.
        public List<Service> AdditionalServices { get; set; }
    }
}
