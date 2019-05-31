using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Vendor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }

        [DefaultValue(false)]
        public bool StateContract { get; set; }

        public string URL { get; set; }

        public int Fax { get; set; }
    }
}