using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Day02.Models.LMS_System;
using MVC_Day02.ViewModel;

namespace MVC_Day02.Controllers
{
  
    public class StudentController : Controller
    {
        LMS_SystemContext context=new LMS_SystemContext();
        StudentBL studentBL = new StudentBL();
        DepartmentBL departmentBL = new DepartmentBL();
        // /Student/GetALL
        public IActionResult GetALL()
        {
            
            List<Student> StuModel = studentBL.GetALL();//Model
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

        // Add
        public IActionResult Add()
        {
            ViewData["DeptList"] = new SelectList(departmentBL.ShowALL(),"Id","Name");//cast >>option
            return View("Add");
        }

        //Save Add
        [HttpPost]
        public IActionResult SaveAdd (Student StuFromReq)
        {
            //if(StuFromReq.Name != null & StuFromReq.Age>=20 & StuFromReq.DepartmentId !=0)
            if(ModelState.IsValid)
            {
                context.Students.Add(StuFromReq);
                context.SaveChanges();
                return RedirectToAction(nameof(GetALL));
            }
            ViewData["DeptList"] = new SelectList(departmentBL.ShowALL(), "Id", "Name");
            return View("Add",StuFromReq);
            
        }

        //delete
        public IActionResult Delete(int id)
        {
            Student student = context.Students.Find(id);
            if(student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            return NotFound();


        }


        // Edit
        public IActionResult Edit(int id)
        {
            ViewData["DeptList"] = new SelectList(departmentBL.ShowALL(), "Id", "Name");
            Student StuFromD= context.Students.FirstOrDefault(s=>s.Id==id);
            /*Student StuIdModel = studentBL.Edit(id);
            List<Department> DeptList=context.Departments.ToList();
            StudentWithDeptListViewModel StuViewModel = new StudentWithDeptListViewModel();
            StuViewModel.Name= StuIdModel.Name;
            StuViewModel.Age= StuIdModel.Age;
            StuViewModel.Id= StuIdModel.Id;
            StuViewModel.DepartmentId= StuIdModel.DepartmentId;
            StuViewModel.DeptList=DeptList;*/
            return View("Edit", StuFromD);


        }

        public IActionResult SaveEdit(StudentWithDeptListViewModel StuFromRequest, int id)
        {
            if (StuFromRequest.Name != null)
            {
                Student studentFromDB = context.Students.FirstOrDefault(s => s.Id == id);
                studentFromDB.Name = StuFromRequest.Name;
                studentFromDB.Age = StuFromRequest.Age;
                studentFromDB.DepartmentId = StuFromRequest.DepartmentId;
                context.SaveChanges();
                return RedirectToAction(nameof(GetALL));

            }
            ViewData["DeptList"] = new SelectList(departmentBL.ShowALL(), "Id", "Name");
            return View("Edit", StuFromRequest);


        }
        //Search
        public IActionResult SearchByName(string name)
        { 
         List<Student> student = context.Students.Where(s=>s.Name.Contains(name)).ToList();
            return View(student);

        }
    }
}
