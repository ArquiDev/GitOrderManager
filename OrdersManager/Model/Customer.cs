﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Model
{
    public class Customer
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String CompleteName => $"{FirstName} {LastName}".Trim();
    }
}
