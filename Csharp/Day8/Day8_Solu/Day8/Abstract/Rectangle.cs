using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Abstract
{
    internal class Rectangle:Shape
    {
         double length;
        double width;

        public Rectangle(double width , double length)
        {
            this.width = width;
            this.length = length;
        }
        public override double GetArea()
        {
            return length * width;
        }
        public override string ToString()
        {
            return $"Rectangle Area is :{GetArea()}";
        }
    }
}
