using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DivisionID { get; set; }

        public int DepartmentID { get; set; }

        public string JobTitle { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Campus { get; set; }
    }
}
