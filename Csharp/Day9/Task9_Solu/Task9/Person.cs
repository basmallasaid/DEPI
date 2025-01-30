using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Department { get; set; }
        public void details()
        {
            Console.WriteLine($" Id : {Id}, Name: {Name}, Department: {Department} ");
        }



    }
   
}
