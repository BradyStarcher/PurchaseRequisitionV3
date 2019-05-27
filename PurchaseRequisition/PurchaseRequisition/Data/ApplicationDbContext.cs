using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PurchaseRequisition.Models;

namespace PurchaseRequisition.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
