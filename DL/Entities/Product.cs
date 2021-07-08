using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Product
    {
        public Product()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
