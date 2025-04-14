using System.ComponentModel.DataAnnotations;
using MVC_Day02.Models.LMS_System;

namespace MVC_Day02.Models
{
    public class UniqueNameAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //check value null
            if (value == null)
                return null;
            //catch value
           string Name= value.ToString();
            //search in DB
            LMS_SystemContext context=new LMS_SystemContext();
           Department DeptFromDB= context.Departments.FirstOrDefault(D=>D.Name==Name);
            if(DeptFromDB != null)
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
