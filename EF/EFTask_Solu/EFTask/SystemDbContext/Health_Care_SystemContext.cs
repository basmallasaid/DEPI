using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTask.Models.Health_Care_System;
using Microsoft.EntityFrameworkCore;

namespace EFTask.SystemDbContext
{
    public class Health_Care_SystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=HealthCare_System;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                 .HasOne(a => a.Patient)
                 .WithMany(p => p.Appointments)
                 .HasForeignKey(f => f.PatientId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(p => p.Appointments)
                .HasForeignKey(f => f.DoctorId);

            modelBuilder.Entity<Appointment>()
                .HasKey(k => new { k.PatientId, k.DoctorId });


        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
