using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerEntities.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int SellerId { get; set; }
        public DateTime datetime { get; set; }
        public string PaymentMethod { get; set; }
    }
}
