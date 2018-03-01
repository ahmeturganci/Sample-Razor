using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    [MetadataType(typeof(OrderMETA))]
    public partial class OrderMETA
    {


        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Order Id")]
        public int id { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Customer_Id Id")]
        public Nullable<int> customer_id { get; set; }

        
    }
}
