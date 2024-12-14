using System;
using Day7.Inheritance;
using Day7.Interface;

namespace Day7
{
    internal class Program
    {
        static void Main()
        {
            #region Q1 class car
            //Car carone = new Car(1);
            //Console.WriteLine(carone);
            //Car cartwo = new Car(2, "Tesla");
            //Console.WriteLine(cartwo);
            //Car carthree = new Car(3, "BMW", 2356667);
            //Console.WriteLine(carthree);
            #endregion

            #region Q2 class Calculator
            //Calculator calc=new Calculator();
            //int Sum1 = calc.SumTowNumber(2, 3);
            //Console.WriteLine($"Sum two intger Number:{Sum1}");
            //int Sum2 = calc.SumThreeNumber(2, 4, 6);
            //Console.WriteLine($"Sum three intger Number:{Sum2}");
            //double Sum3 = calc.SumTowNumber(2.5,5.3);
            //Console.WriteLine($"Sum two double Number:{Sum3}");
            #endregion

            #region Q3 Inheritance sum 
            //Parent objone = new Child(4, 6, 8);
            //int Sum = objone.Sum();
            //Console.WriteLine($"Sum:{Sum}");
            //Console.WriteLine( objone );

            #endregion

            #region Q4 Inheritance Product
            //Parent objtwo = new Child(1, 6, 5);
            //int Product = objtwo.Product();
            //Console.WriteLine($"Product:{Product}");
            //Console.WriteLine(objtwo);

            #endregion

            #region Q5 Override the ToString method (Inheritance)
            //Parent parent = new Parent(1, 6);
            //Console.WriteLine($"Parent : ( {parent} )\n");
            //Child child = new Child(1, 6, 4);
            //Console.WriteLine($"Child : ( {child} )\n");
            //Parent poly = new Child(1, 6, 4);
            //Console.WriteLine($"polymorphism:( {poly} )");
            #endregion

            #region Q6  interface IShape Area rectangle
            //IShape rectangle = new Rectangle { Width = 10, Height = 20 };
            //Console.WriteLine(rectangle);
            //rectangle.Draw();
            #endregion

            #region Q7 interface IShape Area circle
            //IShape circle = new Circle { Radius = 7 };
            //circle.Draw();
            //circle.PrintDetails();
            #endregion

            #region Q8 interface IMovable
            //IMovable car = new CarInterface ();
            //car.Move();

            #endregion

            #region Q9 interface IReadable
            //IReadable read = new File();
            //read.Read();
            //IWritable write = new File();
            //write.Write();
            #endregion

            #region Q10 class Shape 
            //Rectangle rectangle = new Rectangle { Width=3, Height=4};
            //rectangle.Draw();
            //double area= rectangle.CalculateArea();
            //Console.WriteLine($"Area :{area}");
            #endregion
        }
    }
}
