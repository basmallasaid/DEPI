using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Task1.Configuration;
using EFTask.Configuration.E_System_Configuration;
using EFTask.Models;
using EFTask.Models.E_System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EFTask.SystemDbContext
{
    public class E_SystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=E_System;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            new ProjectEntityConfiguration()
                .Configure(modelBuilder.Entity<Project>());

            new OrderEntityConfiguration()
                .Configure(modelBuilder.Entity<Order>());

            new ProductEntityConfiguration()
                .Configure(modelBuilder.Entity<Product>());

            new OrderDetailEntityConfiguration()
                .Configure(modelBuilder.Entity<OrderDetail>());

            modelBuilder.Entity<OrderDetail>()
                .HasKey(OP => new { OP.OrderId, OP.ProductId });//primaryKey

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
