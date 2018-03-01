using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Product
    {
        public Product()
        {
            this.OrderItems = new List<OrderItem>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
