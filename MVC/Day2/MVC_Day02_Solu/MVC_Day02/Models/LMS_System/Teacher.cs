﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day02.Models.LMS_System
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
