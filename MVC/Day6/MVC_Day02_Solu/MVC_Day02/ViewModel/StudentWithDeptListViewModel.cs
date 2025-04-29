using MVC_Day02.Models.LMS_System;

namespace MVC_Day02.ViewModel
{
    public class StudentWithDeptListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public List<Department> DeptList { get; set; }
    }
}
