using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTask.Models.E_System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFTask.Configuration.E_System_Configuration
{
    internal class OrderEntityConfiguration:IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o => o.Customers)
                .WithMany(c => c.Orders)
                .HasForeignKey(f => f.CustomerId);

        }

    }
}
