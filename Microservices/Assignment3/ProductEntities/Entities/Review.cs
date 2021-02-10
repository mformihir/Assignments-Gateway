using System;
using System.Collections.Generic;
using System.Text;

namespace ProductEntities.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string ReviewDesc { get; set; }
        public DateTime Date { get; set; }

    }
}
