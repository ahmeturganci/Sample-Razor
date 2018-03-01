using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class OrderItemVM
    {
        public OrderItem OrderItem { get; set; }
        public IEnumerable<OrderItem> OrderItemList{ get; set; }
    }
}
