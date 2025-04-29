using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Day02.Models.LMS_System;

namespace MVC_Day02.Controllers
{
    public class StuCrsResController : Controller
    {
        LMS_SystemContext context=new LMS_SystemContext();
        // GET: StuCrsRes
        public ActionResult Index()
        {
            ViewData["CourseList"] = new SelectList(context.Courses.ToList());
            ViewData["StuList"] = new SelectList(context.Students.ToList());
            List<StuCrsRes> stuCrsRes=context.StuCrsRes.ToList();
            return View(stuCrsRes);
        }

        // Add Student in Crs
        public IActionResult AddStuCrs()
        {
            ViewData["CourseList"] = new SelectList(context.Courses.ToList());
            ViewData["StuList"] = new SelectList(context.Students.ToList());
            return View();
        }
        public IActionResult SaveAddStuCrs(StuCrsRes StuFromReq)
        {
            if (ModelState.IsValid)
            {
                context.StuCrsRes.Add(StuFromReq);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseList"] = new SelectList(context.Courses.ToList());
            ViewData["StuList"] = new SelectList(context.Students.ToList());
            return View("AddStuCrs", StuFromReq);
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // Add
        public ActionResult Create()
        {
            return View();
        }

        //SaveAdd
        [HttpPost]
      
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // Edit
        public ActionResult Edit(int id)
        {
            return View();
        }

        //SaveEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // Delete
        public ActionResult Delete(int id)
        {
            return View();
        }

       
    }
}
