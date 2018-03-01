using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Order
    {
        public Order()
        {
            this.OrderItems = new List<OrderItem>();
        }

        public int id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
