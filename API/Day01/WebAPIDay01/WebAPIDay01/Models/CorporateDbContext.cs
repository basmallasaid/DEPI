using Microsoft.EntityFrameworkCore;

namespace WebAPIDay01.Models
{
    public class CorporateDbContext:DbContext
    {
        public  DbSet<Department> Departments { get; set; }
        public DbSet<course> Courses { get; set; }
        public CorporateDbContext(DbContextOptions<CorporateDbContext> options): base(options)
        {
            
        }
    }
}
