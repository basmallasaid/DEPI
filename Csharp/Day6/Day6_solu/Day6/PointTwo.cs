using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    struct PointTwo
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointTwo(int x)
        {
            X = x;
            Y = 0;
        }
        public PointTwo(int x,int y)
        {
            X = x;
            Y = y;  
        }
        public override string ToString() 
        {
            return $"first paramter X:{X}, second paramter Y:{Y}";
        }
    }
}
