﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.Library_System
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Book> Books { get; set; }
    }
}
