using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class TypeA
    {
        private int f;
        internal int g;
        public int h;

        public int F
        {
            get { return f; } // can access in scope
            set { f = value; }
        }
        public int G
        {
            get { return g; }// can access
            set { g = value; }
        }
        public int H
        {
            get { return h; }// can access
            set { h = value; }
        }
            
    }
    

}
