
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MVC_Day02.Models.LMS_System
{
    public class StudentBL
    {
        LMS_SystemContext context=new LMS_SystemContext();

        public List<Student> GetALL()
        {
            List<Student> StudentList = context.Students.ToList();
            return StudentList;
        }
        public Student Detalis(int id)
        {
            Student student = context.Students.FirstOrDefault(p=>p.Id == id);
            return student;
        }
        
        public Student Edit(int id)
        {
            Student student = context.Students.FirstOrDefault(p => p.Id == id);
            return student;
        }
        public void SaveAdd(Student StuSend)
        {
            context.Students.Add(StuSend);
             context.SaveChanges();
        }




    }
}
