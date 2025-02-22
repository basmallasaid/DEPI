using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.E_System
{
    public class Product
    {

        public int Id { get; set; }
        public string Product_Name { get; set; }
        public  int Price { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Categories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
