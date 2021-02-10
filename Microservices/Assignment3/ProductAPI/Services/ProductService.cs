using ProductEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>()
            {
                new Product() {Id = 1, Description = "Test", ManufacturerId = 1, Name = "iPhone", Price = 11000,QnaId = 1, ReviewId = 1, SellerId = 1, stock = 100},
                new Product() {Id = 2, Description = "Test", ManufacturerId = 1, Name = "iPhone", Price = 11000,QnaId = 1, ReviewId = 1, SellerId = 1, stock = 100},
            };

            return products;
        }
    }
}
