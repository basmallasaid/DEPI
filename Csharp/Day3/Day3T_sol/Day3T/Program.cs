using System;
using System.Text;
using Microsoft.VisualBasic;

namespace Day3T
{
    internal class Program
    {
        static void Main()
        {
            #region Q1 convert
            //using int.parse
            /*
            Console.WriteLine("Enter age !");
            string input=Console.ReadLine();
            int age = int.Parse(input);
            Console.WriteLine($"age using parse :{age} " );
            */

            //using convert.toint32
            /*
            Console.WriteLine("Enter age !");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            Console.WriteLine($"age using convert :{age}");
            */
            //handel try Bouns
            /*
            Console.WriteLine("Enter age !");
            string input = Console.ReadLine();
            try
            {
                int age = Convert.ToInt32(input);
                Console.WriteLine($"age using parse :{age} ");

            }
            catch (FormatException error)
            {
                Console.WriteLine($"catch this is error: {error.Message}"); // when enter anything other than numbers 
            }
            catch (OverflowException error) {
                Console.WriteLine($"catch this is error: {error.Message}");// when enter large value or small value in size
            }
            catch(ArgumentNullException error)
            {
                Console.WriteLine($"catch this is error: {error.Message}");
            }*/

            // difference handling null
            /*
            string input = null;
             int result = Convert.ToInt32(input); // Returns 0
             Console.WriteLine(result);
            */
            /*
            string input = null;
            int  result = int.Parse(input); // unhandled Exception
            Console.WriteLine(result);*/

            #endregion

            #region Q2 TryParse
            /*
            Console.WriteLine("Enter Number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int Num)) {  
                Console.WriteLine($" this is num valid :{Num}");
            }
            else {
                Console.WriteLine($"Not valid :{Num}");
            }
            */

            //TryParse recommended over Parse??
            /* TryParse take string input and return int value && anything other than num return 0
               parse when enter anything other than num return error unhandled Exception
             */
            #endregion

            #region Q3 obj GetHashCode
            /*
            object obj;
            obj = 22;
            Console.WriteLine($"value : {obj}, GetHashCode : {obj.GetHashCode()} ");
            obj = "basmala";
            Console.WriteLine($"value : {obj}, GetHashCode : {obj.GetHashCode()} ");
            obj = 50.87;
            Console.WriteLine($"value : {obj}, GetHashCode : {obj.GetHashCode()} ");
            */
            //Explain the real purpose of the GetHashCode() method? Use "hash code" to locate the object quickly.
            #endregion

            #region Q4 ref point
            /*
            Point obj1;
            obj1 = new Point();
            Point obj2 = new Point();
            obj2 = obj1;
            obj1.X = 5;
            Console.WriteLine(obj2.X);
            obj1.X = 89;
            Console.WriteLine(obj2.X);
            obj1.Y = "basmala";
            Console.WriteLine(obj2.Y);
            obj1.Y = "Muhammed";
            Console.WriteLine(obj2.Y);
            */
            //What is the significance of reference equality in .NET? To check if two variables refer to the same object in memory
            #endregion

            #region Q5 string
            /*
            string Msg = "Hi";
            Console.WriteLine($"before :{Msg} ,HashCode :{Msg.GetHashCode()}");
            Msg += " Willy";
            Console.WriteLine($"After :{Msg} ,HashCode :{Msg.GetHashCode()}");
            */
            //Why string is immutable in C# ? can't change value>>Arrays of Characters>>fixed size
            #endregion

            #region Q6 StringBuilder
            /*
            StringBuilder sb;
            sb = new StringBuilder("Hi");
            Console.WriteLine($"before :{sb} ,HashCode :{sb.GetHashCode()}");
            sb.Append(" Willy");
            Console.WriteLine($"After :{sb} ,HashCode :{sb.GetHashCode()}");
            */
            //How does StringBuilder address the inefficiencies of string concatenation?
            //once create string , value hashcode can't changed when concatenate strings, a new string 

            #endregion

            #region Q7
            //Why is StringBuilder faster for large-scale string modifications?
            /* avoids repeated memory allocations
             * uses a dynamic resizes
             */
            #endregion

            #region Q8 String Formatting
            /*
            Console.WriteLine(" Enter Two Number !");
             int Num1=int.Parse( Console.ReadLine());
             int Num2 = int.Parse(Console.ReadLine());
             int Sum=Num1 + Num2;
             Console.WriteLine("Sum Concatenation " + Num1 + " + " + Num2 + " = " + Sum);
            Console.WriteLine("Sum Composite formatting {0}+{1}={2}", Num1, Num2, Sum);
            Console.WriteLine($"Sum String interpolation {Num1} + {Num2} = {Sum}");
            */
            //Which string formatting method is most used and why? String interpolation>>Readability
            #endregion

            #region Q9 StringBuilder Method
            /*
            StringBuilder SB;
            SB= new StringBuilder("Hi");
            SB.Append(" Basmala");
            Console.WriteLine(SB);
            SB.Replace(" Basmala", " EveryOn");
            Console.WriteLine(SB);
            SB.Insert(10, "e");
            Console.WriteLine(SB);
            SB.Remove(2,9);
            Console.WriteLine(SB);
            */
            //Explain how StringBuilder is designed to handle frequent modifications compared to strings.
            /* string each concatenation operation creates a new string object, cause Create more allocation in momery
             * StringBuilder modifies its internal buffer, so no new objects are created with each concatenation
            */
            #endregion



        }
    }
}
