using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Interface
{
    public interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }

    // SquareSeries implementation
    public class SquareSeries : IShapeSeries
    {
        private int Length;

        public int CurrentShapeArea { get; set; }

        public SquareSeries()
        {
            Length = 0;
            CurrentShapeArea = 0;
        }

        public void GetNextArea()
        {
            Length++;
            CurrentShapeArea = Length * Length;
        }

        public void ResetSeries()
        {
            Length = 0;
            CurrentShapeArea = 0;
        }
    }

    // CircleSeries implementation
    public class CircleSeries : IShapeSeries
    {
        private int Radius;

        public int CurrentShapeArea { get; set; }

        public CircleSeries()
        {
            Radius = 0;
            CurrentShapeArea = 0;
        }

        public void GetNextArea()
        {
           Radius++;
            CurrentShapeArea = (int)(Math.PI *Radius * Radius);
        }

        public void ResetSeries()
        {
            Radius = 0;
            CurrentShapeArea = 0;
        }
    }

    public class ShapePrinter
    {
        public static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine($"Shape {i + 1} Area: {series.CurrentShapeArea}");
            }
        }
        public static void PrintSortedShapes(List<Shape> shapes)
        {
            shapes.Sort();
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }

    }
    public class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape shape)
        {
            return Area.CompareTo(shape.Area);
        }

        public override string ToString()
        {
            return $"{Name}: Area = {Area}";
        }
    }
}