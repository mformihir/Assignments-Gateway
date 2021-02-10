using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerEntities.Entities
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
    }
}
