﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.E_System
{
    public class Customer
    {
        public int Id { get; set; }
        public string CutomerName { get; set; }
        public string Email { get; set; }

        public List<Order> Orders { get; set; }
    }
}
