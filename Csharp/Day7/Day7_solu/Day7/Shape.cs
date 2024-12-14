using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
        public abstract double CalculateArea();
    }
    class Rectangle:Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void Draw() 
        {
            Console.WriteLine($"rectangle is width {Width} , height {Height}");
        }


    }
}
