using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<Product> ProductList { get; set; }

    }
}
