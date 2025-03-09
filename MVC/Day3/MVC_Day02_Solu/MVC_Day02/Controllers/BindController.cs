using Microsoft.AspNetCore.Mvc;

namespace MVC_Day02.Controllers
{
    public class BindController : Controller
    {
        public IActionResult Test(string name , int Age)
        {
            return Content($"{name } , {Age}");
        }
    }
}
