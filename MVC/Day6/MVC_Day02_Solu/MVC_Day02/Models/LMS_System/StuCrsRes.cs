using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day02.Models.LMS_System
{
    public class StuCrsRes
    {
        [ForeignKey("Student")]
        [Required]
        public int StudentId { get; set; }
        public Student ?Student { get; set; }
        [ForeignKey("Course")]
        [Required]
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        
        [Required]
        public decimal? Degree { get; set; }
        public string? Grade
        {
            get
            {
                if (Course?.Degree == null || Course.Degree == 0)
                    return "Unknown";

                decimal percentage = (decimal)(((decimal)Degree / Course.Degree) * 100);

                if (percentage >= 90)
                    return "A";
                else if (percentage >= 80)
                    return "B";
                else if (percentage >= 70)
                    return "C";
                else if (percentage >= 60)
                    return "D";
                else
                    return "F";
            }
        }


    }
}






