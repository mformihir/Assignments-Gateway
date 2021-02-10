using ShippingEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingAPI.Services
{
    public class ShippingService
    {
        public List<ShippingDetails> GetShippings()
        {
            var shippings = new List<ShippingDetails>()
            {
             new ShippingDetails() { Id = 1, ProductId = 1, CustomerId = 1, ETA = TimeSpan.FromHours(1), Status = "On the way"},
             new ShippingDetails() { Id = 2, ProductId = 1, CustomerId = 2, ETA = TimeSpan.FromHours(2), Status = "On the way"}
            };
            return shippings;
        }
    }
}
