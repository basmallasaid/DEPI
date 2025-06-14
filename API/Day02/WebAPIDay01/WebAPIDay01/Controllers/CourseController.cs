using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDay01.Models;
using WebAPIDay01.Models.Context;

namespace WebAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CorporateDbContext context;

        public CourseController(CorporateDbContext _context)
        {
            context = _context;
        }
        //GetALL
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Course> CrsList = context.Courses.ToList();
            if (CrsList != null)
            {
               
                return Ok(CrsList);

            }
            return NotFound();
        }
        //GetById
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Course Crs = context.Courses.FirstOrDefault(c => c.Id == id);
            if (context.Courses != null)
            {
                return Ok(Crs);
            }
            return NotFound();
        }
        //GetByName
        [HttpGet("{Name:alpha}")]
        public IActionResult GetByName(string Name)
        {
            Course Crs = context.Courses.FirstOrDefault(c => c.Crs_Name == Name);
            if (Crs != null)
            {
                return Ok(Crs);
            }
            return NotFound();
        }
        //Add
        [HttpPost]
        public IActionResult Add(Course Crs)
        {
            if (Crs != null)
            {
                context.Courses.Add(Crs);
                context.SaveChanges();
                return CreatedAtAction(nameof(GetById), new { id = Crs.Id }, Crs);
            }
            return NotFound();
        }
        //Update
        [HttpPut("{id:int}")]
        public IActionResult Update(Course courseFromReq ,int id)
        {
             Course CrsFromDB = context.Courses.FirstOrDefault(c => c.Id == courseFromReq.Id);
            if (CrsFromDB != null)
            {
                CrsFromDB.Crs_Name = courseFromReq.Crs_Name;
                CrsFromDB.Crs_Desc = courseFromReq.Crs_Desc;
                CrsFromDB.Crs_Duration = courseFromReq.Crs_Duration;
                context.SaveChanges();
                return NoContent();

            }
            return NotFound();
        }
        //Delete
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            Course CrsFromDB = context.Courses.FirstOrDefault(c => c.Id == id);
            if (CrsFromDB != null)
            {
                context.Courses.Remove(CrsFromDB);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
