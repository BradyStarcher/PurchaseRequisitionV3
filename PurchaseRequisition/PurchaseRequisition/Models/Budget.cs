using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Budget
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string DACode { get; set; }

        public double Amount { get; set; }

        public string Status { get; set; }

        public string Department { get; set; }
    }
}
