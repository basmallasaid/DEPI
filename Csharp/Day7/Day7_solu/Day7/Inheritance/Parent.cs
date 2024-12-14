using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Inheritance
{
    internal class Parent
    {
        #region Prop
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region ctor
        public Parent(int _X,int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion

        #region Method
        public virtual int Sum()
        {
            return X + Y;
        }
        public virtual int Product()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
        #endregion
    }
}
