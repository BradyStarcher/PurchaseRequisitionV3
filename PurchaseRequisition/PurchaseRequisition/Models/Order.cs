using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Order
    {
        public int ID { get; set; }

        public string Status { get; set; }

        public string BusinessJustification { get; set; }

        public int TotalCostOfItems { get; set; }

        public int ItemID { get; set; }

        public int BudgetCodeId { get; set; }

        public string ApproverCode { get; set; }

        public string RejectionReason { get; set; }

        public string DivisionChair { get; set; }
    }
}
