using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDay01.DTO;
using WebAPIDay01.Models;
using WebAPIDay01.Models.Context;

namespace WebAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly CorporateDbContext context;

        public DepartmentController(CorporateDbContext _context)
        {
            context = _context;
        }
        //GetALL
        [HttpGet]
        public IActionResult GetAll()
        {
            //Logic
           List<Department> DeptList =context.Departments
                .Include( D => D.Students)
                .Include(C=>C.Courses)
                .ToList();
            //helpers methods
            return Ok(DeptList);//200
        }
        [HttpGet("GetDeptDetails")]
        public IActionResult GetDeptDetails()
        {
            var DeptListDTO = context.Departments
                .Include(d => d.Students)
                .Include(d => d.Courses)
                .Select(d => new DeptWithStuCountDTO
                {
                    Id = d.Id,
                    DeptName = d.Name,
                    DeptStuCount = d.Students.Count,
                    DeptCrsCount = d.Courses.Count
                })
                .ToList();
            return Ok(DeptListDTO); // 200 OK
        }

        //GetById
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            //Logic
            Department Dept = context.Departments
                .Include(D => D.Students)
                .Include(C => C.Courses)
                 .FirstOrDefault(d => d.Id == id);
            //helpers methods
            if(Dept != null)
            {
                
                return Ok(Dept);//200
            }
            return NotFound();//404
        }
        //GetByName
        [HttpGet("{Name:alpha}")]
        public IActionResult GetByName(string Name)
        {
            //Logic
            Department Dept = context.Departments
                .Include(D => D.Students)
                .Include(C => C.Courses)
                .FirstOrDefault(d => d.Name == Name);
            //helpers methods
            if (Dept != null)
            {

                return Ok(Dept);//200
            }
            return NotFound();//404
        }
        //Add
        [HttpPost]
        public IActionResult Add(Department dept)
        {
            //Logic
            context.Departments.Add(dept);
            context.SaveChanges();
            //helpers methods
            return CreatedAtAction(nameof(GetById), new { id = dept.Id }, dept);//201
        }
        //update
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Department deptFromReq)
        {
            //Logic
            if (id != deptFromReq.Id)
            {
                return BadRequest();
            }
           Department deptFromDB=context.Departments.FirstOrDefault(d => d.Id == id);
            deptFromDB.Name = deptFromReq.Name;
            deptFromDB.MgrName = deptFromReq.MgrName;
            context.SaveChanges();
            //helpers methods
            return NoContent();//204
        }
        //Delete

    }
}
