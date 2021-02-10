using ShippingEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingAPI.Services
{
    public class SellerService
    {
        public List<Seller> GetSellers()
        {
            var sellers = new List<Seller>()
            {
             new Seller() { Id = 1, Name = "Test Seller 1", ProductId = 1},
             new Seller() { Id = 2, Name = "Test Seller 2", ProductId = 1},
            };

            return sellers;
        }
    }
}
