using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDay01.Models;

namespace WebAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //HttpGet مش بيعرف يعمل request body
        [HttpGet("{Age:int}/{Name:alpha}")] //لازم يكون موجود لعمل روتين GET >>requerd (id , name)
        public IActionResult TestOne(int Age , string? Name)
        {
            return Ok("Test One is working fine");
        }
        [HttpPost]
        public IActionResult TestTwo(Department obj, string? Name) // لو كان في MVC كان هيكون في مشكله علشان هو بياخد الداتا من مكان واحد
        {
            return Ok("Test Two is working fine");
        }
    }
}
