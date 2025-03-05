using Microsoft.AspNetCore.Mvc;
using MVC_APP.Models;

namespace MVC_APP.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowALL()
        {    // declare
            StudentBL studentBL = new StudentBL();
            // initial
            List<Student> studentListModel=studentBL.GetStudents();//model
            //return
            return View("ShowALL",studentListModel);

        }
        public IActionResult Details(int id)
        {
            StudentBL Std = new StudentBL();
            Student StdIdModel = Std.GetID(id);
            return View("ShowDetails", StdIdModel);
        }
    }
}
