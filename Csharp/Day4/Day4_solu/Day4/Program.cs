using System;
enum DayOfWeek
{
    Saturday=1, Sunday,Monday, Tuesday, Wednesday, Thursday, Friday
}

namespace Day4
{
    internal class Program
    {

        static void Main()
        {
            #region part 1
            #region Q1 array
            ////first way
            /*
            int [] arr=new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter Element {i}");
                 arr[i] =Convert.ToInt32( Console.ReadLine());
            }
            for(int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine($"Elment in array [{i}]:{arr[i]} \n");
            }
            */
            ///or
            /*
            int[] arr3 = new int[3] { 4, 7, 2 };
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine($"Elment in array [{i}]:{arr3[i]} \n");
            }
            */
            ////second way
            /*
            int[] arr2 = { 3, 6, 9, 2 }; //syntax sugar
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"Elment in array [{i}]:{arr2[i]} \n");
            }
            */
            ////third way
            /*
            int[] arr3 = new int[] { 9, 4, 2 };
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine($"Elment in array [{i}]:{arr3[i]} \n");
            }
            */
            ////Demonstrates an Index Out Of Range Exception. 
            /*
            try
            {
                int[] arr2 = { 3, 6, 9, 2 };
                Console.WriteLine(arr2[5]);//out of range
            }
            catch (IndexOutOfRangeException error) {
                Console.WriteLine($"an error occurred : {error}");
            }
            */
            #endregion

            #region Q2 Copy Array
            ///first way 
            /*
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];    
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Enter Element {i}");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine($"Elments in array1 :{string.Join(", ", arr1)}");//(searched for string.join)

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i]=arr1[i];
                Console.WriteLine($"Elment in array2 [{i}]:{arr2[i]} \n");
            }
            */
            ///second way shallow copy
            /*
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            arr2 = arr1;//copy address
            Console.WriteLine($"Elment[0] in array1 : {arr1[0]}");
            Console.WriteLine($"Elment[0] in array2 : {arr2[0]}");
             arr1[0] = 8;//modify 1 into 8
            Console.WriteLine($"Elment[0] in array1 modify : {arr1[0]}");
            Console.WriteLine($"Elment[0] in array2 modify : {arr2[0]}");
            */
            ///third way deep copy
            /*
            int[] arr1 = { 1, 2, 3 };//modify 1 into 8
            int[] arr2 = (int[])arr1.Clone();
            Console.WriteLine($"Elment[0] in array1 : {arr1[0]}");
            Console.WriteLine($"Elment[0] in array2 : {arr2[0]}");
            arr1[0] = 8;//modify 1 into 8
            Console.WriteLine($"Elment[0] in array1 modify : {arr1[0]}");
            Console.WriteLine($"Elment[0] in array2 modify : {arr2[0]}");
            */
            ///fourth way method copy()
            /*
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = new int[3];
            Array.Copy(arr1,arr2, arr1.Length);
            Console.WriteLine($"Elment[0] in array1 : {arr1[0]}");
            Console.WriteLine($"Elment[0] in array2 : {arr2[0]}");
            arr1[0] = 8;//modify 1 into 8
            Console.WriteLine($"Elment[0] in array1 modify : {arr1[0]}");
            Console.WriteLine($"Elment[0] in array2 modify : {arr2[0]}");
            */
            #endregion

            #region Q3 2D array
            /*
            int[,] grade= new int [3,3];
            for (int i = 0; i < grade.GetLength(0); i++)//  row
            {
                Console.WriteLine($"Enter grades for Student {i+1}:");
                for (int j = 0; j < grade.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter Subject {j+1}:");// col
                    grade[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Grades for each student:");
            for (int i = 0; i < grade.GetLength(0); i++)
            {
                Console.WriteLine($"Student {i+1}:");
                for (int j = 0; j < grade.GetLength(1); j++)
                {
                    Console.Write(grade[i, j] + " ");

                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Q4 Methods of Array
            /*
            int[] arr = { 3, 10, 9, 15, 1 };
            Console.WriteLine($"Original array :{string.Join(", ", arr)}");
            Array.Sort(arr);
            Console.WriteLine($"sort array :{string.Join(", ", arr)}");
            Array.Reverse(arr);
            Console.WriteLine($"Reverse array :{string.Join(", ", arr)}");
            int index=Array.IndexOf(arr, 3);
            Console.WriteLine($"index[3] :{index}");
            int[] arr2 = new int[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            Console.WriteLine($"Copy array :{string.Join(", ", arr2)}");
            Array.Clear(arr,1,2);
            Console.WriteLine($"after CLR: {string.Join(",", arr)}");
            */
            #endregion

            #region Q5 Loop
            //for
            /*
            int[] arr = { 3, 6, 9, 2 }; 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"FOR Elment in array [{i}]:{arr[i]}");
            }
            Console.WriteLine();
            */
            //foreach
            /*
            foreach(int i in arr )
            {
                Console.WriteLine($"FOREACH Elment in array :{i}");
            }
            Console.WriteLine();
            */
            //while
            /*
            int n = 0;
            while (n<arr.Length)
            {
                Console.WriteLine($"WHILE Elment in array [{n}]:{arr[n]}");
                n++;
            } ;
            */
            #endregion

            #region Q6 dowhile
            /*
            int Num;
            bool flag;
            do
            {
                Console.Write("Please enter a positive odd number: ");
                flag = int.TryParse(Console.ReadLine(), out Num);
            }
            while (Num % 2 == 0 || !flag || Num < 0);
            */
            #endregion

            #region Q7  2D array with fixed values
            /*
             // 2D
            int[,] data = { { 1, 2 }, { 3, 4 } };
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Num of ({ i },{ j }) :{data[i, j]} \n");
                }
                Console.WriteLine();
            }
            */
            //format 2D
            /*
            int[,] data = { { 1, 2 }, { 3, 4 } };

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            Console.Write("        ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($" Col{j+ 1,2} ");
            }
            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Row {i + 1,2} : ");

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{data[i, j],4} ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Q8 switch & if_else
            //if_else
            /*
            Console.Write("Enter The Month Number : ");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());
            string MonthName;
            if (MonthNumber == 1) MonthName = "January";
            else if (MonthNumber == 2) MonthName = "February";
            else if (MonthNumber == 3) MonthName = "March";
            else if (MonthNumber == 4) MonthName = "April";
            else if (MonthNumber == 5) MonthName = "May";
            else if (MonthNumber == 6) MonthName = "June";
            else if (MonthNumber == 7) MonthName = "July";
            else if (MonthNumber == 8) MonthName = "August";
            else if (MonthNumber == 9) MonthName = "September";
            else if (MonthNumber == 10) MonthName = "October";
            else if (MonthNumber == 11) MonthName = "November";
            else if (MonthNumber == 12) MonthName = "December";
            else MonthName = "Invalid Month number!";
            Console.WriteLine($"(if-else) The month is: {MonthName}");
            */
            //switch
            /*
            Console.Write("Enter The Month Number : ");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());
            string MonthName;
            switch (MonthNumber)
            {
                case 1:
                    MonthName = "January";
                    break;
                case 2:
                    MonthName = "February";
                    break;
                case 3:
                    MonthName = "March";
                    break;
                case 4:
                    MonthName = "April";
                    break;
                case 5:
                    MonthName = "May";
                    break;
                case 6:
                    MonthName = "June";
                    break;
                case 7:
                    MonthName = "July";
                    break;
                case 8:
                    MonthName = "August";
                    break;
                case 9:
                    MonthName = "September";
                    break;
                case 10:
                    MonthName = "October";
                    break;
                case 11:
                    MonthName = "November";
                    break;
                case 12:
                    MonthName = "December";
                    break;
                default:
                    MonthName = "Invalid month number!";
                    break;
            }
            Console.WriteLine($"(switch) The month is: {MonthName}");
            */
            #endregion

            #region Q9 search 
            //IndexOf (searched this point)
            /*
            int[] arr = { 3, 10,1, 9, 15, 1 };
            Console.WriteLine($"Original array :{string.Join(", ", arr)}");
            Array.Sort(arr);
            Console.WriteLine($"sort array :{string.Join(", ", arr)}");

            Console.Write("Enter a value to search for: ");
            int valueToSearch = Convert.ToInt32(Console.ReadLine());
            int firstIndex = Array.IndexOf(arr, valueToSearch);

            if (firstIndex != -1)
            {
                Console.WriteLine($"The first occurrence of {valueToSearch} is at index {firstIndex}.");
            }
            else
            {
                Console.WriteLine($"{valueToSearch} was not found in the array.");
            }

            int lastIndex = Array.LastIndexOf(arr, valueToSearch);

            if (lastIndex != -1)
            {
                Console.WriteLine($"The last occurrence of {valueToSearch} is at index {lastIndex}.");
            }
            else
            {
                Console.WriteLine($"{valueToSearch} was not found in the array.");
            }
            */
            #endregion

            #region Q10 array cal sum
            //for
            /*
            int[] arr = { 3, 6, 9, 2 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum+=arr[i];
            }
            Console.WriteLine($"Sum using for loop: {sum}");
            */
            //foreach
            /*
            int[] arr = { 3, 6, 9, 2 };
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"Sum using foreach loop: {sum}");
            */
            #endregion
            #endregion

            #region part 2
            /*
            Console.WriteLine("Enter a number (1-7) to get the day of the week:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            }
            else
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());
                Console.WriteLine($"The corresponding day is: {day}");
            }
            */
                #endregion

            }
    }
}
