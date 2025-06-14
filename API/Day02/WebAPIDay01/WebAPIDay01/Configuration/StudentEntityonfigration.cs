using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPIDay01.Models;

namespace WebAPIDay01.Configuration
{
    public class StudentEntityonfigration:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        { 
            builder.ToTable("Students");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);
            
        }

    }
}
