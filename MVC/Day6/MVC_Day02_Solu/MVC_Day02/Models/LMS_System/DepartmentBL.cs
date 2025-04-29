using Microsoft.EntityFrameworkCore;
using MVC_Day02.ViewModel;

namespace MVC_Day02.Models.LMS_System
{
    public class DepartmentBL
    {
        LMS_SystemContext context=new LMS_SystemContext();

        public List<Department> ShowALL()
        {
            List<Department>DeptList =context.Departments.Include(D => D.Students).ToList();
            return DeptList;
        }
        //public DeptWithExtraInfoViewModel Details(int id)
        public Department Details(int id)
        {
            Department dept = context.Departments
                .Include(D => D.Students)
                .FirstOrDefault(d => d.Id == id);
             return dept;

            //if (dept == null) ///way2
            //{
            //    return null;
            //}
            //var studentName=dept.Students //Age
            //    .Where(d => d.Age > 25)
            //    .Select(d => d.Name)
            //    .ToList();
            //var DeptState = dept.Students.Count > 50 ? "Main" : "Branch";//State

            //return new DeptWithExtraInfoViewModel
            //{
            //    DeptName = dept.Name,
            //    DeptState = DeptState,
            //    StudentName = studentName
            //};

        }
        public void AddDept(Department DeptSent)
        { //Memory
            context.Departments.Add(DeptSent);
            //DB
            context.SaveChanges();
        }


    }
}
