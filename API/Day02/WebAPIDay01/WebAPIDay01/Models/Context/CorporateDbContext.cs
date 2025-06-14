using Microsoft.EntityFrameworkCore;
using WebAPIDay01.Configuration;

namespace WebAPIDay01.Models.Context
{
    public class CorporateDbContext:DbContext
    {
      
        public CorporateDbContext(DbContextOptions<CorporateDbContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentEntityonfigration());
            modelBuilder.ApplyConfiguration(new DepartmentEntityonfigration());
            modelBuilder.ApplyConfiguration(new CourseEntityonfigration());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
