using System;
using System.Collections.Generic;
using System.Text;

namespace ProductEntities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int stock { get; set; }
        public int ManufacturerId { get; set; }
        public int SellerId { get; set; }
        public int ReviewId { get; set; }
        public int QnaId { get; set; }
    }
}
