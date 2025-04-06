using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    struct Point
    {
        //Prop
        public int X { get; set; }
        public int Y { get; set; } 
        //parameter
        public Point(int _X , int _Y)
        {
           X = _X;
           Y = _Y;
           Console.WriteLine($"Paramterized constractor: X is {X} , Y is {Y}");
        }
        //override
        public override string ToString()
        {
            return $"override:first Coor is {X}, Second Coor is {Y} \n";
        }
    }
}
