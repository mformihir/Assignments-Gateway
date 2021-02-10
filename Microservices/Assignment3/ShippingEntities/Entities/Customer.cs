﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingEntities.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
