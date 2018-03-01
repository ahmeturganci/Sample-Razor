using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    [MetadataType(typeof(OrderItemMETA))]
    public partial class ProductMETA
    {

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Product Id")]
        public int id { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Product Name")]
        public string name { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Product Description")]
        public string description { get; set; }
        
    }
}
