using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.E_System
{
    public class Category
    {
        public int Id { get; set; }
        public string Category_Name { get; set; }
       
        public List<Product> Products { get; set; }
    }
}
