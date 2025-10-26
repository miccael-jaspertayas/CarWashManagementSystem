using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.Core
{
    public class Expense
    {
        // Declaration of the expense properties.
        public DateTime Date { get; set; }
        public string ItemName { get; set; }
        public double Amount { get; set; }
    }
}
