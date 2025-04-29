using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day02.Models.LMS_System
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal?Degree { get; set; }
        [Required]
        public decimal?MinDegree { get; set; }

        [ForeignKey("Department")]
        [Required]
        [Range(1, 40)]
        public int  DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<StuCrsRes>? StuCrsRes { get; set; }

    }
}
