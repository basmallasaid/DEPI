using System;
using System.Drawing;
namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            //Declare and initialize y with value of 20
            int y = 20;
            //Declare and initialize x with value of 10
            int x = 10;
            /*
             Calculate Sum x,y
             and Store value in a variable sum.
            */
            int sum = x + y;
            //print result
            Console.WriteLine($"Answer to Q1 is: {sum}");
            /* shortcut to comment Ctrl +k /c or Ctrl+?
            shotcut to uncomment Ctrl +k /u or Ctrl+?*/
            #endregion

            #region Q2
            /*int z = "10"; assign strint to int!
             console.WriteLine(z+k); c# Sensitivity && not declare K*/
            //correct code
            int k = 5;
            int z = 10;
            Console.WriteLine($"Answer to Q2 is: {k + z}");

            //int num1 = 10;
            //int num2 = 0;
            //Console.WriteLine(num1 / num2);//runtime error (div by zero)

            int width = 3;
            int height = 6;
            int area=width + height;//Logical error (area=width * height) not +
            Console.WriteLine($"area is: {area}");
            #endregion

            #region Q3
            //declary using PascalCase
            string FullName = "Basmala Said";
            int Age = 22;
            float MonthlySalary = 8000.5f;
            bool IsStudent = true;
            //More Readability && Collaboration
            #endregion

            #region Q4
            Point P1 = new Point();
            Point P2 = new Point();
            Console.WriteLine($"Answer to Q4 is: {P1.X}");//0
            P2 = P1;
            P1.X = 5;
            Console.WriteLine($"Answer to Q4 is: {P2.X} \n______________________________");//5
            //Value types are stored in memory on the stack, but ref has two places ,
            //the first place store address of the object (stack) && secode place store value of the object (heap)

            #endregion

            #region Q5
            int x1 = 15;
            int y1 = 4;
            int Sum=x1 + y1;
            int Sub=x1 - y1;
            int Product = x1 * y1;
            float Div =(float) x1 / y1 ;
            int Remainder = x1 % y1;
            Console.WriteLine($"Answer to Q5 is: \nsum={Sum} \nsub={Sub} \nproduct={Product} \nDiv={Div} \nRemainder={Remainder}");
            int a = 2, b = 7;
            Console.WriteLine($"Ans(2 % 7)={a % b} ,because 2 is less than 7 \n---------------------");//2 because 2 is less than 7
            #endregion

            #region Q6
            Console.WriteLine("Enter Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num >10 && Num % 2 == 0)
            {
                Console.WriteLine($"Number is Valid");
            }
            else
            {
                Console.WriteLine("Number is not Valid");
            }
            //logical AND the first value false short circuit ,but bitwise AND compare bit to bit 
            #endregion

            #region Q7
            long Num4 = 88;
            int Num5 =(int)Num4;
            Console.WriteLine($"Answer to Q7 is :{Num5}");
            #endregion

            #region Q8
            Console.WriteLine("Enter your age");
            string age=Console.ReadLine();
            int num=int.Parse(age);
            if (num > 0)
            {
                Console.WriteLine("is valid");
            }
            else {
                Console.WriteLine("Not valid");
            }
            #endregion

            #region Q9
            int n = 5;
            int o = ++n + n++;// ++n=1+x=6 , n++=6 use value x  >> 6+6=12
            Console.WriteLine(o);
            #endregion


        }
    }
}
