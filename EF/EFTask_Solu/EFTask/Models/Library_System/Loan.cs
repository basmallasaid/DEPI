using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.Library_System
{
    public class Loan
    {
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Borrower")]
        public int BorrowerId { get; set; }

        public Borrower Borrower { get; set; }

        public Book Book { get; set; }
    }
}
