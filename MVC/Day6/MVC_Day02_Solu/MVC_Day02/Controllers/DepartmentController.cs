using Azure;
using Microsoft.AspNetCore.Mvc;
using MVC_Day02.Models.LMS_System;
using MVC_Day02.ViewModel;

namespace MVC_Day02.Controllers
{
    public class DepartmentController : Controller
    {
        LMS_SystemContext context = new LMS_SystemContext();
        DepartmentBL DeptBl = new DepartmentBL();
        public IActionResult GetALL()
        {
          
           List<Department>DeptListModel =DeptBl.ShowALL();
            DeptWithExtraInfoViewModel DVM = new DeptWithExtraInfoViewModel();
            
            return View("GetALL",DeptListModel);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        public IActionResult Details(int id)
        {
            Department DeptModel = DeptBl.Details(id);
            return View("Details", DeptModel);
        }

        // /Department/SaveAdd?Name=bbb&MrgName=ghg
        [HttpPost] //filter
        public IActionResult SaveAdd(Department NewDeptFromRes)
        {
            if (ModelState.IsValid) 
            {
                context.Departments.Add(NewDeptFromRes);
                context.SaveChanges();
                return RedirectToAction(nameof(GetALL));
            }
            return View("Add", NewDeptFromRes);



            /*DepartmentBL deptBl = new DepartmentBL();
             if (NewDeptFromRes.Name != null)
             {

                 deptBl.AddDept(NewDeptFromRes);
                 return RedirectToAction(nameof(GetALL));
             }
               return View("Add",NewDeptFromRes);*/

        }
        //Edit
        public IActionResult Edit(int id)
        {
            Department DeptFromDB = context.Departments.FirstOrDefault(D=>D.Id==id);
            return View("Edit",DeptFromDB);

        }
        [HttpPost]
        public IActionResult SaveEdit(Department DeptFromReq, int id)
        {
            if (ModelState.IsValid)
            {
                Department DeptFromDB = context.Departments.FirstOrDefault(d => d.Id == id);
                DeptFromDB.Name = DeptFromReq.Name;
                DeptFromDB.MgrName = DeptFromReq.MgrName;
                context.SaveChanges(); 
                return RedirectToAction(nameof(GetALL));
            }

            return View("Edit", DeptFromReq);
        }

        public IActionResult DetailsVM(int id)
        {
            Department DeptModel = DeptBl.Details(id);//Model

            DeptWithExtraInfoViewModel DeptVM = new DeptWithExtraInfoViewModel();//View Model

            if (DeptModel == null)
            {
                return NotFound();
            }
            var StudentName=DeptModel.Students //Age
                .Where(s=>s.Age>25)
                .Select(s=>s.Name)
                .ToList();
            var DeptState = DeptModel.Students.Count > 50 ? "Main" : "Branch";//State

            DeptVM.DeptState = DeptState;
            DeptVM.StudentName = StudentName;
            DeptVM.DeptName = DeptModel.Name;
            return View("DetailsVM", DeptVM);



            /*var DeptModel=DeptBl.Details(id);//Way2
            if (DeptModel == null) {
                return NotFound();
            }

            return View("Details",DeptModel);*/
        }
        //Delete
        public IActionResult Delete(int id) 
        {
            Department dept=context.Departments.Find(id);
            if(ModelState.IsValid)
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
                return RedirectToAction("GetALL");
            }
            return NotFound();

        }
    }
}
