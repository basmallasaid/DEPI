using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EFTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task1.Configuration
{
    internal class ProjectEntityConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(10, 10);

            builder.Property(x => x.Name)
               .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValue("OurProject");

            builder.Property(c => c.Cost)
                 .HasColumnType("money");
            builder.HasCheckConstraint("CK_Project_Cost", "[Cost] BETWEEN 500000 AND 3500000");


        }

    }
}
