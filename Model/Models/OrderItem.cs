using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class OrderItem
    {
        public int id { get; set; }
        public Nullable<int> order_id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> quantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
