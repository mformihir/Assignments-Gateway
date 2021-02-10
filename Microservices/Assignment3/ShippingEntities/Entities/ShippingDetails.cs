using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingEntities.Entities
{
    public class ShippingDetails
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public TimeSpan ETA { get; set; }
        public string Status { get; set; }
    }
}
