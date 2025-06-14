using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPIDay01.Models;

namespace WebAPIDay01.Configuration
{
    public class DepartmentEntityonfigration:IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        { 
            builder
                .ToTable("Departments");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasMany(d => d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId);
        }
    }
}
