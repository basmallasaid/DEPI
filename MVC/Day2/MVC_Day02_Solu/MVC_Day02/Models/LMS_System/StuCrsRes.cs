using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day02.Models.LMS_System
{
    public class StuCrsRes
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string Grade { get; set; }


    }
}






