using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Abstract
{
    internal class Circle:Shape
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI*radius * radius;
        }
        public override string ToString()
        {
            return $"Circle Area is : {GetArea()}";
        }
    }
}
