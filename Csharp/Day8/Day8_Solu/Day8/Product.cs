﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int CompareTo(Product value)
        { 
            return Price.CompareTo(value.Price);
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }


    }
}
