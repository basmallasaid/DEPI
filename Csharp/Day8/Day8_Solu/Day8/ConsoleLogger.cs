using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day8.Interface;

namespace Day8
{
    internal class ConsoleLogger:ILogger
    {
      public void Log()
        {
            Console.WriteLine(" implementation in a class");
        }
    }
    public class Helper:ILogger
    {

    }
}
