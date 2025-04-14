using System.ComponentModel.DataAnnotations;

namespace MVC_Day02.Models.LMS_System
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [UniqueName (ErrorMessage ="Name is Repeated")]
        public string Name { get; set; }
        public string?MgrName { get; set; }
        public List<Student>? Students { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Teacher>? Teachers { get; set; }
    }
}
