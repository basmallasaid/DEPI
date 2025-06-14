using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPIDay01.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
