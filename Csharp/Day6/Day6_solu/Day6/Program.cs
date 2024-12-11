using System;

namespace Day6
{
    internal class Program
    {
        static void Main()
        {
            #region Q1 struct (class Point)
            /*
            Point P1 = new Point(5, 6);//output paramter ctor
            Console.WriteLine(P1);
            P1 =new Point();// output default
            Console.WriteLine(P1);
            */
            #endregion

            #region Q2 access modifier (class typeA)
            /*
            TypeA obj1=new TypeA();
            obj1.h = 1;//public can access in same project and out project
            obj1.g = 2; //internal can access in same project 
            //obj1.f = 3; //private can not access out scope
            */
            #endregion

            #region Q3 class Employee
            /*
            Employee Emp1= new Employee(1,"basmala",5000);
            Emp1.print();
            Employee Emp2 = new Employee();
            Emp2.Name = "sara";
            Emp2.Salary = 3000;
            Emp2.EmpId = 2;
            Emp2.print();
            */
            #endregion

            #region Q4 parameterized constructor specific value (class PointTwo)
            /*
            PointTwo P1= new PointTwo();//(0,0) default
            Console.WriteLine(P1);
            PointTwo P2= new PointTwo(3);//(3,0) parameterized constructor one
            Console.WriteLine(P2);
            PointTwo P3= new PointTwo(4,5);//(4,5) parameterized constructor two
            Console.WriteLine(P3);
            PointTwo P4= new PointTwo(6,7);
            Console.WriteLine(P4);
            */
            #endregion

            #region Q5 Create a struct Point and a class Employee
            /*
            PointTwo p1 = new PointTwo();
            p1.X = 9;
            p1.Y = 10;
            Console.WriteLine(p1);
            Employee Emp1 = new Employee();
            Emp1.Name = "Ali";
            Emp1.EmpId = 3;
            Emp1.Salary = 67880;
            Console.WriteLine(Emp1);
            */
            #endregion

            #region part2 copy constructor (class Enemy)
            /*
            Enemy enemyone = new Enemy("Zombie", 3);
            Console.WriteLine("paramter constructor");
            Console.WriteLine(enemyone);
            Enemy enemyTwo = new Enemy(enemyone);
            Console.WriteLine("Copy constructor");
            Console.WriteLine(enemyTwo);
            */

            #endregion

        }
    }
}
