using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EFTask.Models.E_System;

namespace EFTask.Models
{     //Part 1
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

      
    }
}
