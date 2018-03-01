using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    [MetadataType(typeof(CustomerMETA))]
    public partial class CustomerMETA
    {

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Customer Id")]
        public int id { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Customer Name")]
        public string name { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Customer Surname")]
        public string surname { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Customer Email")]
        public string email { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Customer Password")]
        public string password { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "Meta_Range_Incorrect")]
        [Display(Name = "Customer Phone No")]
        public string phoneNo { get; set; }
        
    }
}
