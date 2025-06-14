using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPIDay01.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? Crs_Name { get; set; }

        [MinLength(10 , ErrorMessage = "Description must be at least 10 characters long")]
        public string? Crs_Desc{ get; set; }
        public int? Crs_Duration { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
