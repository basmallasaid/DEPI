using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    struct Employee
    {
        //attributes
        private int empid;
        private string name;
        private int salary;

        //constructor
        public Employee(int _emdid, string _name , int _salary)
        {
            empid = _emdid;
            name = _name;
            salary = _salary;
        }
        //method
        public int EmpId {
            get {  return empid; }
            set { empid = value; }    
            
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void print()
        {
            Console.WriteLine($"EmpId :{EmpId} , Name :{Name} , Salary :{Salary}");
        }
        public override string ToString()
        {
           return $"EmpId :{EmpId} , Name :{Name} , Salary :{Salary}";
        }
    }
   
}
