using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade{ get; set; }
        public Student(int _Id, string _Name, string _Grade)
        {
            Id = _Id;
            Name = _Name;
            Grade = _Grade;
        }
        public Student(Student value)
        {
            Id = value.Id;
            Name = value.Name;
            Grade = value.Grade;
        }
        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Grate: {Grade}";
        }
    }
  
}
