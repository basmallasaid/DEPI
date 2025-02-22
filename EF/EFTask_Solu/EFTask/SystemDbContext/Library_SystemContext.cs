using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTask.Configuration.Library_System_Configuration;
using EFTask.Models.Library_System;
using Microsoft.EntityFrameworkCore;
namespace EFTask.SystemDbContext
{
    internal class Library_SystemContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Library_System;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BookEntityConfiguration()
               .Configure(modelBuilder.Entity<Book>());

            new LoanEntityConfiguration()
                .Configure(modelBuilder.Entity<Loan>());

            modelBuilder.Entity<Loan>()
                .HasKey(k => new { k.BorrowerId, k.BookId });//primaryKey
            

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Borrower> Borrowers { get; set;}
        public DbSet<Loan> Loans { get; set; }

    }
}
