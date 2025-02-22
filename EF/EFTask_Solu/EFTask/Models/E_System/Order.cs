using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.E_System
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
