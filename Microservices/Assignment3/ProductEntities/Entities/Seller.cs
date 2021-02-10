using System;
using System.Collections.Generic;
using System.Text;

namespace ProductEntities.Entities
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
    }
}
