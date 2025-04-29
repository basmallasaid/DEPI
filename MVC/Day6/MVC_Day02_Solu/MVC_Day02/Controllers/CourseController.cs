using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Day02.Models.LMS_System;

namespace MVC_Day02.Controllers
{
    public class CourseController : Controller
    {
        LMS_SystemContext context=new LMS_SystemContext();
        
        // GET: Course
        public ActionResult Index()
        {
            ViewData["DeptList"] = new SelectList(context.Departments.ToList(),"Id","Name");
            List<Course> courses = context.Courses.ToList();
            return View(courses);
        }

        // GET: Course/Details/?
        public ActionResult Details(int id)
        {
            ViewData["DeptList"] = new SelectList(context.Departments.ToList(), "Id", "Name");
            Course course = context.Courses.FirstOrDefault(x => x.Id == id);
            return View(course);
           
        }

        // GET: Course/Add
        public ActionResult Add()
        {
            ViewData["DeptList"] = new SelectList(context.Departments.ToList(), "Id", "Name");
            return View();
        }

        
        [HttpPost]
        public ActionResult SaveAdd(Course CourseFromReq)
        {
            if(ModelState.IsValid)
            {
                context.Courses.Add(CourseFromReq);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeptList"] = new SelectList(context.Departments.ToList(), "Id", "Name");
            return View("Add",CourseFromReq);
            
        }

        // GET: Course/Edit/?
        public ActionResult Edit(int id)
        {
            ViewData["DeptList"] = new SelectList(context.Departments.ToList(), "Id", "Name");
            Course course = context.Courses.FirstOrDefault(x => x.Id == id);
            return View(course);
        }

        
        [HttpPost]
        public ActionResult SaveEdit(int id, Course CourseFromReq)
        {
            if(ModelState.IsValid)
            {
               
                Course course=context.Courses.FirstOrDefault(c => c.Id == id);
                course.Name= CourseFromReq.Name;
                course.Degree = CourseFromReq.Degree;
                course.MinDegree = CourseFromReq.MinDegree;
                course.DepartmentId=CourseFromReq.DepartmentId;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["DeptList"] = new SelectList(context.Departments.ToList(), "Id", "Name");
            return View("Edit",CourseFromReq);
            
        }

        //Delete
        public ActionResult Delete(int id)
        {
           Course course = context.Courses.Find(id);
            if (ModelState.IsValid)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
            
        }

    }
}
