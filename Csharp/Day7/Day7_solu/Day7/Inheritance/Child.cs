using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Inheritance
{
    internal class Child:Parent
    {
        #region Properties
        public int Z { get; set; }
        #endregion

        #region ctor
        public Child(int _X,int _Y , int _Z):base(_X,_Y)
        {
            Z = _Z;
        }
        #endregion

        #region Method
        public override int Sum()
        {

            return base.Sum() + Z;
        }
        public override int Product()
        {
            return base.Product()*Z;
        }
        public override string ToString()
        {
            return base.ToString() + $", Z: {Z}";
        }
        #endregion

    }
}
