using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.Library_System
{
    public class Borrower
    {
        public  int Id { get; set; }
        public string Borrow_Name { get; set; }
        public DateTime MembershipDate { get; set; }
        public List<Loan> Loans { get; set; }

    }
}
