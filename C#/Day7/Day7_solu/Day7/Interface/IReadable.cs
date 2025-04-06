using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Interface
{
    internal interface IReadable
    {
        void Read();
    }
    interface IWritable
    {
        void Write();
    }
    class File:IReadable, IWritable
    {
        public void Read() 
        {
            Console.WriteLine("Read file ");
        }
        public void Write()
        {
            Console.WriteLine("write file");
        }
    }
}
