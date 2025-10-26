using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.Core
{
    public class Service
    {
        // Declaration of the transaction properties.
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public bool IsFixedPrice { get; set; }

        // Default constructor.
        public Service() { }

        // Cconstructor with parameters.
        public Service(string name, decimal fee, bool isFixedPrice)
        {
            Name = name;
            Fee = fee;
            IsFixedPrice = isFixedPrice;
        }
    }
}
