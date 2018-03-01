using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class OrderVM
    {
        public Order Order { get; set; }
        public IEnumerable<Order> OrderList { get; set; }


    }
}
