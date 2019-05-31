using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Order
    {
        public int ID { get; set; }

        [DefaultValue("In Process")]
        public string Status { get; set; }

        public string BusinessJustification { get; set; }

        public int TotalCostOfItems { get; set; }

        public string Item { get; set; }

        public string BudgetCode { get; set; }

        public string ApproverCode { get; set; }

        public string RejectionReason { get; set; }

        public string DivisionChair { get; set; }
    }
}
