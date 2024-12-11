using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Enemy(string _Name ,int _Level)
        {
            Name = _Name;
            Level = _Level;  
        }
        public Enemy(Enemy enemy)//copy 
        {
            Name=enemy.Name;
            Level = enemy.Level;
        }
        public override string ToString() 
        {
            return $"Enemy Name:{Name} , Level : {Level}";
        }
    }
}
