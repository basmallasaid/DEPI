using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Inheritance
{
    internal class Parent
    {
        public virtual int Salary { get; set; }
        
        public Parent(int salary )
        { 
            Salary = salary;
        }
       


    }
}
