using Microsoft.AspNetCore.Mvc;
using MVC_Day02.Models.LMS_System;

namespace MVC_Day02.Controllers
{
    public class StudentController : Controller
    {
        // /Student/GetALL
        public IActionResult GetALL()
        {
            StudentBL student = new StudentBL();
            List<Student> StuModel = student.GetALL();//Model
            return View("GetALL",StuModel);
        }
        // /Student/Details?id=1
        public IActionResult Details(int id)
        {
            //string mes = "Hello Action (View Data)";
            //int temp = 39;
            //List<string> listItem = new List<string>();
            //listItem.Add("B");
            //listItem.Add("A");
            //listItem.Add("C");
            ////aditional info send to view feom action
            //ViewData["Mes"] = mes;
            //ViewData["Temp"]=temp;
            //ViewData["List"]=listItem;
            //ViewBag.Color = "Red";
            
            StudentBL student = new StudentBL();
            Student StuIdModel = student.Detalis(id);
            return View("Details", StuIdModel);
        }
    }
}
