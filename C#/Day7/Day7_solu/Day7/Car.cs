using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public int Price{ get; set; }

        public Car(int _ID)
        {
            ID = _ID;  
        }
        public Car(int _ID , string _Brand)
        {
            ID= _ID;
            Brand = _Brand;
        }
        public Car(int _ID, string _Brand , int _Price)
        {
            ID=_ID;
            Brand = _Brand;
            Price = _Price;
        }
        public override string ToString()
        {
            return $"car ID :{ID} , Brand : {Brand} , Price :{Price}";
        }
        
    }
}
