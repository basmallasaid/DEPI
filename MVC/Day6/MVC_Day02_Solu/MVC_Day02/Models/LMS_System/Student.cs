using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day02.Models.LMS_System
{
    //display name , type appended
    // validation Criteria
    //suitable Msg 
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        //[DataType(DataType.EmailAddress)] //// type appended
        [Required]
        [MaxLength(50,ErrorMessage ="Less than 50")]
        [MinLength(3,ErrorMessage ="More than 3")]
        [RegularExpression(@"^[a-zA-Z\s]+$",ErrorMessage ="Only contains Letter and Spaces")]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }

        [ForeignKey("Department")]
        [Required]
        [Range(1,40)]
        public int DepartmentId { get; set; }
        public Department?Department { get; set; }
        public List<StuCrsRes>?StuCrsRes { get; set; }

    }
}
