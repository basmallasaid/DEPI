using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Abstract
{
    internal abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public GeometricShape(double dimension1, double dimension2)
        {
            Dimension1 = dimension1;
            Dimension2 = dimension2;
        }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }
    class Triangle : GeometricShape
    {
        public Triangle(double baseLength, double height) : base(baseLength, height) { }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                return 3 * Dimension1;
            }
        }
    }

   class Rectanglee : GeometricShape
    {
        public Rectanglee(double length, double width) : base(length, width) { }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        }
    }


}
