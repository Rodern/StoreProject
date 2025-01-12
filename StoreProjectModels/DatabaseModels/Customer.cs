﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StoreProjectModels.DatabaseModels
{
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        public string CustomerId { get; set; }
        public int NidNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public DateTime DateRegistered { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
