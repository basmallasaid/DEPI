using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPIDay01.Models;

namespace WebAPIDay01.Configuration
{
    public class CourseEntityonfigration:IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Crs_Name)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentId);




        }
    }
    
    
}
