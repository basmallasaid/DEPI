using Microsoft.AspNetCore.Mvc;
using MVC_Day02.Models.LMS_System;

namespace MVC_Day02.Controllers
{
    public class BindController : Controller
    {
        //Bind primitive
        // /Bind/Test/10?name=basmala&age=21&color=red&color=blue
        public IActionResult Test(string name , int Age,int id, string[] color)
        {
            return Content($"{name } , {Age},{color}");
        }
        //Bind Collection
        // /Bind/TestDic?phones[basmala]=123
        public IActionResult TestDic(Dictionary<string,string>phones)
        {
            return Content("OK");
        }
        // Bind Custom Class
        // Bind/Testobj/7?Name=cs&MgrName=ali
        public IActionResult Testobj(Department dept)
        {
            return Content("Done");
        }
    }
}
