using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace WebAPIDay01.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name{ get; set; }
        public string MgrName { get; set; }
        //[JsonIgnore]
        public ICollection<Student>? Students { get; set; }
        public ICollection<Course>? Courses { get; set; }

    }
}
