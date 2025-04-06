using System;
using System.Linq;
using System.Security.Cryptography;

namespace Day5
{
    internal class Program
    {
        #region part1
        #region Q2 TestDefensiveCode
        /*
        public static void TestDefensiveCode() {
            int Num1, Num2,res;
            do
            {
                Console.WriteLine("Enter first Number !");
            } while (!int.TryParse(Console.ReadLine(), out Num1) || Num1 <= 0);
            do
            {
                Console.WriteLine("enter second number :");
            } while (!int.TryParse(Console.ReadLine(), out Num2) || Num2 <= 1);
            res = Num1 / Num2;
            Console.WriteLine(res);
        }*/
        #endregion
        #region Q9 function SumMultiply
        //  static void SumAndMultiply(int Num1, int Num2, out int sum, out int product)
        //{
        //    sum = Num1 + Num2;
        //    product = Num1 * Num2;
        //}
        #endregion
        #region Q10 function print
        //static void Print(string Txt, int Num = 5) {
        //    for (int i = 0; i < Num; i++) {
        //        Console.WriteLine(Txt + i); 
        //    }

        //}
        #endregion
        #region Q13 function  SumArray
        /*
        public static void SumArray(params int[]arr) 
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            Console.WriteLine($"sum:{sum}");

        }
        */
        #endregion
        static void Main()
        {

            #region Q1 DivideByZeroException
            /*
            try
            {
                Console.WriteLine("Enter first number !");
                int Num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number !");
                int Num2 = int.Parse(Console.ReadLine());
                int div;
                div = Num1 / Num2;
                Console.WriteLine($"div : {div}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error:DivideByZeroException");
            }
            finally {
                Console.WriteLine("Operation complete");
            }
            */
            #endregion

            #region Q3 nullable
            /*
            int? Num =null;
            int total = Num ?? 0;
            Console.WriteLine($"using null-coalescing operator : {total}");
            Num = 5;
            if (Num.HasValue)
            {
                Console.WriteLine($"using HasValue: {Num.Value} ");
            }
            else Console.WriteLine("Num is Null");
            ///syntax suger 

            Num = null;
            if (Num.HasValue)
            {
                Console.WriteLine($"using HasValue: {Num.Value} ");
            }
            else Console.WriteLine("Num is Null");
            
            */
            #endregion

            #region Q4 IndexOutOfRangeException
            /*
            try
            {
                int[] Arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine(Arr[6]);
            }
            catch (IndexOutOfRangeException) {
                Console.WriteLine("Error:IndexOutOfRangeExceptio");
            }
            */
            #endregion

            #region Q5 Array 3*3
            /*
            int[,] Arr = { { 3, 4, 1 }, { 5, 6, 2 }, { 7, 8, 3 } };
            
            for(int i = 0; i < Arr.GetLength(0); i++) {
                int Rowsum = 0;
                for (int j = 0; j < Arr.GetLength(1); j++) 
                { 
                    Rowsum += Arr[i, j];     
                }
                Console.WriteLine($"Row {i+1} :{Rowsum}");
            }
            Console.WriteLine();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                int Colsum = 0;
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Colsum += Arr[j, i];
                }
                Console.WriteLine($"Col {i + 1} :{Colsum}");
            }
            */
            #endregion

            #region Q6 Jagged array
            /*
            int[][] Arr = new int[2][];
            Arr[0] = new int[3] { 1, 2, 3 };
            Arr[1] = new int[2] { 6, 7 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"ROW{i + 1}:");
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write($"{Arr[i][j]} ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Q7 nullable string
            /*
            string ? Txt1 ;
            Console.WriteLine("enter value");
            string input=Console.ReadLine() ?? string.Empty;
            Txt1 = string.IsNullOrWhiteSpace(input) ? null : input;
            Console.WriteLine($"output :{Txt1!}");
            */
            #endregion

            #region Q8 boxing and unboxing
            ///boxing int>> object , V>>R
            /*
            int Value = 3;
            object obj = new object();
            obj = Value;
            Console.WriteLine($"Box value :{obj}");
            */
            /// unboxing obj>>int R>>v
            /*
            try
            {
                int Value2;
                Object obj2 = new Object();
                obj2 =4;
                Value2 = (int)obj2;
                Console.WriteLine($"unBox value :{Value2}");
            }
            catch (InvalidCastException e) 
            {
                Console.WriteLine($"Error:InvalidCastException {e.Message}");
            }
           */



            #endregion

            #region Q9 function SumAndMultiply 
            /*
            int sum, product;
            SumAndMultiply(3,5,out sum,out product);
            Console.WriteLine($"sum :{sum}");
            Console.WriteLine($"product:{product}");
            #endregion
            */

            #endregion

            #region Q10 print string

            //Print("hello"); // default Num=5
            //Print("hello", 2);

            #endregion

            #region Q11 nullable integer array
            /*
            int?[] Arr = null;  
            Arr = new int?[] { 1,null ,2, 3 };
            int ? index=Arr?[0];
            int? index1 = Arr?[1];
            Console.WriteLine($"first element: {index}");
            Console.WriteLine($"second element: {index1}");
            */
            #endregion

            #region Q12 switch day of the week
            /*
            Console.WriteLine("Enter day of the week !");
            string input=Console.ReadLine().Trim().ToLower();//senstive 
            int numday;
            switch (input)
            {
                case "saturday":
                    numday = 1;
                    break;
                case "sunday":
                    numday = 2;
                    break;
                case "monday":
                    numday = 3;
                    break;
                case "tuesday":
                    numday = 4;
                    break;
                case "wednesday":
                    numday = 5;
                    break;
                case "thursday":
                    numday = 6;
                    break;
                case "friday":
                    numday = 7;
                    break;
                default:
                    numday = 0;
                    break;
            }
            if (numday== 0)
            {
                Console.WriteLine("Invalid day entered.");
            }
            else
            {
                Console.WriteLine($"The day {input} corresponds to number {numday}.");
            }
            */
            #endregion

            #region Q13 SumArray
            //SumArray( 1,3,5,7);

            #endregion
            #endregion


            #region part2
            #region Q1 Print Numbers in a Range 
            /*
            Console.WriteLine("Enter positive Number !");
            int Num=int.Parse(Console.ReadLine());
            if (Num > 0)
            {
                for (int i = 1; i <= Num; i++)
                {
                    Console.WriteLine($"{i}\n");
                }

            }
            else {
                Console.WriteLine("this number not valid");
            }
            */
            #endregion

            #region Q2 Multiplication Table 
            /*
            Console.WriteLine("Enter Number !");
            int Num=int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{Num}*{i} : {Num*i} ");
            }
            */
            #endregion

            #region Q3 Even Numbers
            /*
            Console.WriteLine("Enter Number !");
            int Num=int.Parse(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                if (i % 2 == 0) Console.WriteLine($"Even Number: {i}");
            }
            */
            #endregion

            #region Q4 Compute Exponentiation 
            /*
            Console.WriteLine("Enter First Number !");
            int Num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number !");
            int Num2 = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <= Num2; i++) {
                    res = res * Num1;     
            }
            Console.WriteLine($"{Num1} power {Num2}: {res} ");
            */
            #endregion

            #region Q5 reverse a string
            /*
            Console.WriteLine("Enter string text ");
            string Txt=Console.ReadLine();
            string reversed = "";
            for (int i =Txt.Length-1;i>=0; i--) {
                reversed+= Txt[i];
            }
            Console.WriteLine($"reversed {Txt}:{reversed}");
            */
            #endregion

            #region Q6  Reverse an Integer
            /*
            Console.WriteLine("Enter Number");
            int Num =int.Parse( Console.ReadLine());
            int result = 0;
            while (Num > 0)
            {
                result = result * 10 + Num % 10;
                Num /= 10;
            }
           Console.WriteLine( result);
            
              */
            /////or
            /*
            Console.WriteLine("Enter Number");
            int Num = int.Parse(Console.ReadLine());
            string rev= string.Concat(Num.ToString().Reverse());
            int reverseNum = int.Parse(rev);
            Console.WriteLine($"origin Number:{Num}");
            Console.WriteLine($"reverse Number:{reverseNum}");
            */
            
            #endregion

            #region Q7 Find Longest Distance
            /*
            int[] Arr = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 37, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 37, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            int N = Arr.Length;
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (Arr[i] != Arr[j])
                    {
                        result = Math.Max(result, j - i);
                    }
                }
            }
            Console.WriteLine($"The longest distance is {result}");
            */
            #endregion

            #region Q8 Reverse Words
            /*
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
            */
            #endregion
            #endregion
        }

    }
}
