using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_APP.Models;

namespace MVC_APP.Controllers
{
    public class HomeController : Controller
    {
        //public string Mes()
        //{
        //    return "Hello world";
        //}

        //Action string return
        public ContentResult Mes()
        {
            ContentResult res=new ContentResult();
            res.Content = "Hello1";
            return res;
        }
        // Action View >>Html page
        public ViewResult Viewpage()
        {
            ViewResult res=new ViewResult();
            res.ViewName = "View1";
            return res;
        }
        // Action return (View || Content)
        // /Home/ShowView?id=1
       /// why we use IActionResult not ActionResult support ur answer with scenario or problems
        public IActionResult ShowView(int id)
        {
            if (id % 2 == 0)
            {
                //ViewResult res = new ViewResult(); //way1 
                //res.ViewName = "View1";
                //return res;
               /// return view("View1"); //Way2
               return View("View1"); //way 3
            }
            else 
            {
                //ContentResult res = new ContentResult();
                //res.Content = "Hello1";
                //return res;
                ///return content("HelloContent");
                return Content("hello content Micro");
            }
        }

        //not repeat code (!) or use function microsoft (View, Content,NotFound)
        public ViewResult view(string name)
        {
            ViewResult res = new ViewResult();
            res.ViewName = name;
            return res;
        }
        public ContentResult content(string name)
        {
            ContentResult res = new ContentResult();
            res.Content = name;
            return res;
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
