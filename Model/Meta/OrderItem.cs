using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    [MetadataType(typeof(OrderItemMETA))]
    public partial class OrderItemMETA
    {
        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Order Id")]
        public int id { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Order_id Id")]
        public Nullable<int> order_id { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Product_id Id")]
        public Nullable<int> product_id { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Quantity")]
        public Nullable<int> quantity { get; set; }

     
    }
}
