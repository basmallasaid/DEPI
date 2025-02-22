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
    internal class OrderDetailEntityConfiguration:IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.HasOne(od => od.Products)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(od => od.Orders)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(o => o.OrderId);
           
        }
    }
}
