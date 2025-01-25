using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Book
    {
        //prop
        public string Title { get; set; }
        public string Author { get; set; }

        //ctor
        public Book()
        {
            
        }

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            return $"Title: {Title} , Author: {Author}";
        }
    }
    
}
