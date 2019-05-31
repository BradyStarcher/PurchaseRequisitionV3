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
        //private string connectionString = @"Server=localhost\SQLEXPRESS;database=CapstoneVThree;MultipleActiveResultSets=true;Trusted_Connection=True;";

        public DbSet<PurchaseRequisition.Models.Address> Address { get; set; }
        public DbSet<PurchaseRequisition.Models.Budget> Budget { get; set; }
        public DbSet<PurchaseRequisition.Models.Campus> Campus { get; set; }
        public DbSet<PurchaseRequisition.Models.College> College { get; set; }
        public DbSet<PurchaseRequisition.Models.Department> Department { get; set; }
        public DbSet<PurchaseRequisition.Models.Division> Division { get; set; }
        public DbSet<PurchaseRequisition.Models.Item> Item { get; set; }
        public DbSet<PurchaseRequisition.Models.Order> Order { get; set; }
        public DbSet<PurchaseRequisition.Models.Role> Role { get; set; }
        public DbSet<PurchaseRequisition.Models.Status> Status { get; set; }
        public DbSet<PurchaseRequisition.Models.Vendor> Vendor { get; set; }
    }
}
