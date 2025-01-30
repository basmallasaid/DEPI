using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Inheritance
{
     class Child :Parent
    {
        public Child(int salary):base(salary) {}
        //public sealed void DisplaySalary() //can't  override 
        //{
        //    Console.WriteLine($"Salary: {Salary}");
        //}
        public void DisplaySalary() 
        {
            Console.WriteLine($"Salary: {Salary}");
        }



    }
}
