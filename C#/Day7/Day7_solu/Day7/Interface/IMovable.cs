using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Interface
{
    internal interface IMovable
    {
        void Move();
    }
    public class CarInterface : IMovable
    {
        public void Move() 
        {
            Console.WriteLine("Move right");
        }
    }
}
