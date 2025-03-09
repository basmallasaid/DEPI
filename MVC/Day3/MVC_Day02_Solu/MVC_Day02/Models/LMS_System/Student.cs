using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day02.Models.LMS_System
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<StuCrsRes> StuCrsRes { get; set; }

    }
}
