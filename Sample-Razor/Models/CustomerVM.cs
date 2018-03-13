using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public partial class CustomerVM
    {
        public Customer  Customer { get; set; }
        public IEnumerable<Customer> CustomerList { get; set; }

    }
   
}
