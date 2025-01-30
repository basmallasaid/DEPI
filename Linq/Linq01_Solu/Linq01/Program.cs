using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using static Linq01.ListGenerators; 
namespace Linq01
{
    internal class Program
    {
        static void Main()
        {
            #region LINQ - Restriction Operators
            #region 1,2-Use ListGenerators.cs 
            /// Use ListGenerators.cs  
            //Console.WriteLine("(all products that are out of stock)\n");
            //var prod_OutOfStock = ProductList.Where((prod) => prod.UnitsInStock == 0);
            //foreach (var i in prod_OutOfStock)
            //{
            //    Console.WriteLine($"{i}\n");
            //}

            //Console.WriteLine("________________________________________\n");
            //Console.WriteLine("(all products that are in stock and cost more than 3.00 per unit)\n");
            //var prod_Stock = ProductList.Where((P) => P.UnitsInStock != 0 && P.UnitPrice > 3);
            //foreach (var i in prod_Stock)
            //{
            //    Console.WriteLine($"{i}\n");
            //}
            #endregion

            #region 3-Returns digits whose name is shorter than their value.
            /////List
            //Console.WriteLine("________________________________________\n");
            //Console.WriteLine("digits whose name is shorter than their value\n");
            //string[] digits = { "zero", "one", "two", "three", "four","five", "six", "seven", "eight", "nine" };
            //var shortDigits = digits.Where((digit, index) => digit.Length < index);
            //foreach (var i in shortDigits)
            //{
            //    Console.WriteLine($"digit name:{i} ,Number of Letter:{i.Length} ");
            //}
            #endregion
            #endregion

            #region LINQ - Element Operators 
            #region 1,2-ListGenerators.cs 
            ///Use ListGenerators.cs 
            //Console.WriteLine("(first Product out of Stock)");
            //var first_Prod = ProductList.First((p) => p.UnitsInStock == 0);
            //    Console.WriteLine($"{first_Prod}\n");

            //Console.WriteLine("(the first product whose Price > 1000 )");
            //var Prod = ProductList.FirstOrDefault((p) => p.UnitPrice>1000);
            //Console.WriteLine(Prod?.ProductName ?? "NA");
            #endregion

            #region 3-Retrieve the second number greater than 5 
            ///second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var second_Num = Arr.Where((item) => item > 5)
            //    .OrderBy((item) => item)
            //    .Skip(1)
            //    .First();
            //Console.WriteLine($"second number greater than 5 is {second_Num}");
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1- Count to get the number of odd numbers in the array 
            ///List
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var countOdd = Arr.Count((i) => i % 2 != 0);
            //Console.WriteLine($" the number of odd numbers in the array :{countOdd}");
            #endregion

            #region 2,3- Use ListGenerators.cs  
            ///Use ListGenerators.cs 
            //Console.WriteLine("(list of customers and orders) \n");
            //var customer = CustomerList.Select(c => new { c.Name,c.Orders });

            //foreach (var item in customer)
            //{
            //    Console.WriteLine($"{item.Name} has {item.Orders.Count()} orders.\n");
            //}
            //Console.WriteLine("_______________________________\n");
            //Console.WriteLine("(list of categories and products)\n");
            //var categorie = ProductList.Select((p) => new { p.Category, p.ProductName });
            //foreach (var item in categorie) {
            //    Console.WriteLine($"{item.Category} has {item.ProductName.Count()} products.\n ");
            //}
            #endregion

            #region 4-Get the total of the numbers in an array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Total = Arr.Count();
            //Console.WriteLine(Total);
            #endregion

            #region 6-Get the total units in stock for each product category(bouns)
            //var categories = ProductList.Select(p => p.Category).Distinct()
            //    .OrderBy(p => p);
            //foreach (var category in categories)
            //{
            //    int total = ProductList
            //     .Where(p => p.Category == category)
            //      .Sum(p => p.UnitsInStock);

            //    Console.WriteLine($"{category} has {total} units in stock");
            //}
            #endregion

            #region 8-Get the cheapest price among each category's products (bouns)
            //var category = ProductList.Select((p) => p.Category).Distinct()
            //    .OrderBy((p) => p);
            //foreach (var item in category)
            //{
            //    int min_Price = (int)ProductList
            //        .Where((p) => p.Category == item)
            //        .Min((p) => p.UnitPrice);
            //    Console.WriteLine($" the cheapest price in {item} is {min_Price} ");
            //}
            /// using GroupBy
            //var category=ProductList
            //    .GroupBy (x => x.Category)
            //    .Select(p=>new { Category = p.Key, CheapestPrice=p.Min(g=>g.UnitPrice)});
            //foreach (var item in category)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice}");
            //}
            #endregion

            #region 9-Get the products with the cheapest price in each category (bouns)
            //var categories = ProductList.Select(p => p.Category).Distinct();
            //foreach (var category in categories)
            //{

            //    var cheapestProduct = ProductList
            //        .Where(p => p.Category == category)
            //        .OrderBy(p => p.UnitPrice)
            //        .FirstOrDefault();

            //    if (cheapestProduct != null)
            //    {
            //        Console.WriteLine($"{cheapestProduct.ProductName} is the cheapest product in {category} with a price of {cheapestProduct.UnitPrice}\n");
            //    }
            //}
            /// GroupBy
            //var cheapestProduct = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Gategory = g.Key,
            //        product = g.Where(p => p.UnitPrice == g.Min(prod => prod.UnitPrice))
            //    });
            //foreach (var categoryGroup in cheapestProduct)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Gategory}");
            //    foreach (var product in categoryGroup.product)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}


            #endregion

            #region 11-Get the most expensive price among each category's products. (bouns)
            //var category = ProductList.Select((p) => p.Category).Distinct()
            //    .OrderBy((p) => p);
            //foreach (var item in category)
            //{
            //    int most_Price = (int)ProductList
            //        .Where((p) => p.Category == item)
            //        .Max((p) => p.UnitPrice);
            //    Console.WriteLine($" the most expensive price in {item} is {most_Price} ");
            //}
            /// using GroupBy
            //var category = ProductList
            //    .GroupBy(x => x.Category)
            //    .Select(p => new { Category = p.Key, mostPrice = p.Max(g => g.UnitPrice) });
            //foreach (var item in category)
            //{
            //    Console.WriteLine($"Category: {item.Category}, most Price: {item.mostPrice}");
            //}
            #endregion

            #region 12- Get the products with the most expensive price in each category. (bouns)
            //var categories = ProductList.Select(p => p.Category).Distinct();
            //foreach (var category in categories)
            //{

            //    var MostProduct = ProductList
            //        .Where(p => p.Category == category)
            //        .OrderBy(p => p.UnitPrice)
            //        .LastOrDefault();

            //    if (MostProduct != null)
            //    {
            //        Console.WriteLine($"{MostProduct.ProductName} is the most product in {category} with a price of {MostProduct.UnitPrice}\n");
            //    }
            //}
            /// GroupBy
            //var mostProduct = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Gategory = g.Key,
            //        product = g.Where(p => p.UnitPrice == g.Max(prod => prod.UnitPrice))
            //    });
            //foreach (var categoryGroup in mostProduct)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Gategory}");
            //    foreach (var product in categoryGroup.product)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 14-Get the average price of each category's products. (bouns)
            //var category = ProductList.Select((p) => p.Category).Distinct()
            //    .OrderBy((p) => p);
            //foreach (var item in category)
            //{
            //    var avg_Price = (float)ProductList
            //        .Where((p) => p.Category == item)
            //        .Average((p) => p.UnitPrice);
            //    Console.WriteLine($" the average price in {item} is {avg_Price} ");
            //}
            #endregion
            #endregion

            #region LINQ - Ordering Operators 
            #region 1-Sort a list of products by name
            //var product = ProductList.Select(p => p.ProductName)
            //    .OrderBy(p => p);
            //foreach (var item in product)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2-Uses a custom comparer to do a case-insensitive sort of the words in an array
            //string[] Arr = { "aPPLE","BofdsT" ,"AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" ,"ABC"};
            //var sortedArr = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase).ToArray();
            //Console.WriteLine("Sorted array (case-insensitive):");
            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3-Sort a list of products by units in stock from highest to lowest.
            //var product = ProductList.Select(p => new { p.ProductName, p.UnitsInStock })
            //    .OrderBy(p => p.UnitsInStock);
            //foreach (var prod in product)
            //{
            //    Console.WriteLine(prod);
            //}
            #endregion

            #region 4-Sort a list of digits, first by length of their name, and then alphabetically by the name itself
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
            //var sortedArr = Arr
            //.OrderBy(word => word.Length)
            //.ThenBy(word=>word)
            //.ToArray();
            //foreach (var item in sortedArr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5-Sort first by word length and then by a case-insensitive sort of the words in an array. 
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sort = words
            //    .OrderBy(word => word.Length)
            //    .ThenBy(p => p, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sort)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 6-Sort a list of products, first by category, and then by unit price, from highest to lowest. 
            //var product = ProductList.Select(p => new { p.Category, p.UnitPrice })
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var item in product)
            //{
            //    Console.WriteLine($"{item}\n");
            //}
            #endregion

            #region 7-Sort first by word length and then by a case-insensitive descending sort of the words in an array. 
            //  string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sort = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(p => p, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sort)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 8-Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight" ,"nine" };
            // var word = Arr
            //   .Where(word => word.Length > 1 && word[1] == 'i')
            //   .Reverse ();

            // foreach (var s in word)
            // {
            //   Console.WriteLine(s);
            // }
            #endregion
            #endregion

            #region LINQ – Transformation Operators 
            #region 1-Return a sequence of just the names of a list of products. 
            //var product_Name = ProductList
            //    .Select(p => p.ProductName);
            //foreach (var product in product_Name)
            //{
            //    Console.WriteLine($"{product}\n");
            //}
            #endregion

            #region 2-Produce a sequence of the uppercase and lowercase versions of each word in the original array. 
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var upperLowerWords = words
            // .SelectMany(word => new[] { word.ToUpper(), word.ToLower() });
            //foreach (var word in upperLowerWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3-Produce a sequence containing some properties of Products, including UnitPrice which 
            //var product = ProductList
            //    .Select(p => new { p.ProductID, p.ProductName, p.UnitPrice });
            //foreach (var item in product)
            //{
            //    Console.WriteLine($"{item}\n");
            //}
            #endregion

            #region 4-Determine if the value of ints in an array match their position in the array. 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var num = Arr.Select((p, index) => new { p, inPlace = (p == index) });
            //Console.WriteLine("Number: In-place? \n");
            //foreach (var item in num)
            //{
            //    Console.WriteLine($"{item.p}: {item.inPlace}");
            //}
            #endregion

            #region 5-Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var num = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select (a, b);
            //Console.WriteLine("Pairs where A < B:");
            //foreach (var pair in num)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}
            #endregion

            #region 6-Select all orders where the order total is less than 500.00.
            //var filteredOrders =CustomerList
            //.SelectMany(c => c.Orders)  
            //.Where(o => o.Total < 500.00);
            //foreach (var order in filteredOrders)
            //{
            //    Console.WriteLine(order);
            //}


            #endregion

            #region 7-Select all orders where the order was made in 1998 or later. 
            //var fiterorders = CustomerList
            //    .SelectMany(e => e.Orders)
            //    .Where(o => o.OrderDate.Year>=1998);
            //foreach (var order in fiterorders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion
            #endregion

            #region LINQ - Partitioning Operators 
            #region 1-Get the first 3 orders from customers in Berlin
            //var orders = CustomerList 
            //    .Where(city=>city.City== "Berlin")
            //    .SelectMany(o=>o.Orders)
            //    .Take(3);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 2-Get all but the first 2 orders from customers in Berlin. 
            //var order =CustomerList
            //    .Where(city=>city.City== "Berlin")
            //    .SelectMany(o=>o.Orders)
            //    .Skip(2);
            //foreach (var o in order)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion

            #region 3-Return elements starting from the beginning of the array until a number is hit  that is less than its position in the array. 
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var result = numbers
            //.TakeWhile((num, index) => num >= index);

            // foreach (var i in result)
            // {
            //     Console.WriteLine($"{i}");

            // }
            #endregion

            #region 4-Get the elements of the array starting from the first element divisible by 3. 
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers
            //  .SkipWhile(num => num % 3 != 0)
            //   .ToList();
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region 5-Get the elements of the array starting from the first element less than its position. 
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers
            //    .SkipWhile((num, index) => num >= index);
            //foreach (var i in res)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #endregion

            #region LINQ - Quantifiers 
            #region 2-Return a grouped a list of products only for categories that have at least one product that is out of stock. 
            //var product = ProductList
            //    .Where(p => p.UnitsInStock == 0)
            //    .OrderBy(o => o.Category)
            //     .GroupBy(p => p.Category);

            //foreach (var group in product)
            //{
            //    Console.WriteLine($"Category: {group.Key}\n");
            //    foreach (var p in group)
            //    {
            //        Console.WriteLine($"{p.ProductName} - {p.UnitsInStock} in stock \n");

            //    }
            //    Console.WriteLine("___________ \n");
            //}

            #endregion

            #region 3-Return a grouped a list of products only for categories that have all of their products in stock.
            //var product = ProductList
            //    .Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category);
            //foreach (var group in product)
            //{
            //    Console.WriteLine($"categore: {group.Key}\n");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"product:{item.ProductName},{item.UnitsInStock} in stock \n");
            //    }
            //    Console.WriteLine("____________________________\n");
            //}

            #endregion

            #endregion

        }







    }
}

