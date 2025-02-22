using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTask.Models.Library_System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFTask.Configuration.Library_System_Configuration
{
    public class LoanEntityConfiguration:IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan>builder) 
        {
            builder.HasOne(l => l.Borrower)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BorrowerId);

            builder.HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId);

           


        }
    }
}
