using Microsoft.EntityFrameworkCore;

namespace MVC_Day02.Models.LMS_System
{
    public class LMS_SystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LMS_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StuCrsRes>()
       .HasKey(scr => new { scr.StudentId, scr.CourseId });

            modelBuilder.Entity<StuCrsRes>()
                .HasOne(scr => scr.Course)
                .WithMany(c => c.StuCrsRes)
                .HasForeignKey(scr => scr.CourseId);


            modelBuilder.Entity<StuCrsRes>()
                .HasOne(scr => scr.Student)
                .WithMany(s => s.StuCrsRes)
                .HasForeignKey(scr => scr.StudentId);

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }
    }
}
