using Azure;
using Microsoft.AspNetCore.Mvc;
using MVC_Day02.Models.LMS_System;
using MVC_Day02.ViewModel;

namespace MVC_Day02.Controllers
{
    public class DepartmentController : Controller
    {
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
           DepartmentBL deptBl = new DepartmentBL();
            if (NewDeptFromRes.Name != null)
            {
                
                deptBl.AddDept(NewDeptFromRes);
                return RedirectToAction(nameof(GetALL));
            }

            return View("Add",NewDeptFromRes);

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



            //var DeptModel=DeptBl.Details(id);//Way2
            //if (DeptModel == null) {
            //    return NotFound();
            //}

            //return View("Details",DeptModel);
        }
    }
}
