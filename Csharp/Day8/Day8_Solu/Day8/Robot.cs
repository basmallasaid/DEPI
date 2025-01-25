using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day8.Interface;

namespace Day8
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("using implicit:Robot is walking ");
        }
        void IWalkable.Walk()
        { Console.WriteLine("using explicit:Robot is walking"); }
    }
}
