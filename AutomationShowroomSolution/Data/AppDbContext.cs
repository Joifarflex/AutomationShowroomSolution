using CustomerService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                customerId = 1,
                customerCode = "AA01",
                customerName = "Aaron",
                customerAddress = "PuloGadung",
                createdAt = DateTime.Now,
                createdBy = 1,
                modifiedAt = DateTime.Now,
                modifiedBy = 1,
            });
        }
    }
}
