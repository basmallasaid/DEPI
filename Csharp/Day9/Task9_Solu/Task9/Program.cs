using System;
using Task9.Inheritance;

namespace Task9
{
    internal class Program
    {
        static void Main()
        {
            #region Q1 Enum Weekdays
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"day:{day} Value:{(int)day}");
            //}
            #endregion

            #region Q2 Enum Grades
            //foreach(Grades grad in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"grad: {grad} Value:{(int)grad}");
            //}
            #endregion

            #region Q3 Person class
            //Person person1=new Person { Id=1,Name="basmala",Department="CS"};
            //Person person2 = new Person { Id = 2, Name = "mona", Department = "IT" };
            //person1.details();
            //person2.details();
            #endregion

            #region Q4  Child class
            //Child person = new Child(50000);
            //person.DisplaySalary();
            #endregion
        }
    }
    #region Q1 Enum Weekdays
    //enum Weekdays
    //{
    //    Monday=1,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}
    #endregion

    #region Q2 Enum Grades
    //enum Grades
    //{
    //    F=1,
    //    C,
    //    B,
    //    A
    //}
    #endregion
}
