using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Interface
{
    internal interface IShape
    {
        double Area { get; }
        void Draw();
        void PrintDetails();
    }
    public class Rectangle:IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area 
        {
            get {return Width * Height;}
        }
        public void Draw() 
        {
            Console.WriteLine( $"Area in Rectangle : {Area}");
        }
        public void PrintDetails()
        {
            Console.WriteLine($"width :{Width}, height :{Height},Area in Rectangle : {Area}");
        }
        public override string ToString()
        {
            return $"Area is :{Area}";
        }

    }
    public class Circle : IShape 
    {
        public int Radius { get; set; }
        public double Area
        {
            get {  return Math.PI * Radius * Radius; }
        }
        public void Draw()
        {
            Console.WriteLine($"Area in Circle :{Area}");
        }
        public void PrintDetails() 
        {
            Console.WriteLine($"redius : {Radius} , Area : {Area}");
        }

    }
}
