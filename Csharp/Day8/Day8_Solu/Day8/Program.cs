using System;
using System.Collections.Generic;
using Day8.Abstract;
using Day8.Inheritance;
using Day8.Interface;
using Day8.Struct;
using Shape = Day8.Interface.Shape;

namespace Day8
{
    internal class Program
    {
        #region Sorting part2 (Shape Hierarch)
        public static void SelectionSort(double[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
              
                double temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
        #endregion
        static void Main()
        {
            #region Part 1
            #region Q1 interface IVehicle (class inheritance car & bike)
            //IVehicle car = new Car();
            //IVehicle bike = new Bike();
            //Console.WriteLine("Car operations:");
            //car.StartEngine();
            //car.StopEngine();
            //Console.WriteLine("\nBike operations:");
            //bike.StartEngine();
            //bike.StopEngine();
            #endregion

            #region Q2 Abstract class 
            //Shape rectangle = new Rectangle(4.0, 5.0);
            //Console.WriteLine(rectangle);

            //Shape circle = new Circle(7.0);
            //Console.WriteLine(circle);

            #endregion

            #region Q3 compare products (class product)

            //Product[] products = new Product[]
            //{
            //new Product(1, "Product1", 3556),
            //new Product(2, "Product2", 6944),
            //new Product(3, "Product3", 5667),
            // };
            //Array.Sort(products);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q4  copy constructo (class student)
            //Student student = new Student(1,"basmala","A");
            //Console.WriteLine($"defualt constrain\n{student}\n");
            ////deep
            //Student student1 = new Student(student);
            //Console.WriteLine($"copy constrain");
            //Console.WriteLine($"deep\n{student1}");
            ////shallow
            //Student student2 = student;
            //Console.WriteLine($"shallow\n{student2}");
            #endregion

            #region Q5 interface IWalkable (class robots)
            ////implicit
            //Robot robot = new Robot();
            //robot.Walk();
            ////explicit
            //IWalkable walkable = new Robot();
            //walkable.Walk();
            #endregion

            #region Q6 Struct Account
            //Account account = new Account(1,"basmala",50000);
            //Console.WriteLine(account);

            #endregion

            #region Q7 interface ILogger 
            //ConsoleLogger consoleLogger = new ConsoleLogger();
            //consoleLogger.Log();//class
            //ILogger logger = new ConsoleLogger();
            //logger.Log();//class
            //ILogger logger1 = new Helper();
            //logger1.Log();//interface

            #endregion

            #region Q8 class Book 
            //Book book = new Book();
            //Book book1 = new Book("Rules of Life");
            //Book book2 = new Book("Rules of Life","Richard");
            //Console.WriteLine("ctor default");
            //Console.WriteLine(book);
            //Console.WriteLine("ctor 1");
            //Console.WriteLine(book1);
            //Console.WriteLine("ctor 2");
            //Console.WriteLine(book2);

            #endregion

            #endregion

            #region Part 2
            #region  IShapeSeries
            //Console.WriteLine("Square Series:");
            //IShapeSeries squareSeries = new SquareSeries();
            //ShapePrinter.PrintTenShapes(squareSeries);
            //Console.WriteLine("Circle Series:");
            //IShapeSeries circle= new CircleSeries();
            //ShapePrinter.PrintTenShapes(circle);

            //    var shapes = new List<Shape>
            //{
            //    new Shape("Square",66),
            //    new Shape("Circle", 20.5),
            //    new Shape("Rectangle", 29),
            //    new Shape("Square", 36),
            //    new Shape("Circle", 49)
            //};

            //    ShapePrinter.PrintSortedShapes(shapes);
            #endregion

            #region Shape Hierarchy(abstract Geometric)
        //    List<GeometricShape> shapes = new List<GeometricShape>
        //{
        //    new Triangle(5, 10),
        //    new Triangle(6, 8),
        //    new Rectanglee(4, 7),
        //    new Rectanglee(10, 3)
        //};

        //    Console.WriteLine("Shapes and their properties:");
        //    foreach (var shape in shapes)
        //    {
        //        Console.WriteLine($"Shape: {shape.GetType().Name}, Area: {shape.CalculateArea()}, Perimeter: {shape.Perimeter}");
        //    }


            #endregion

            #endregion


        }
    }
}
