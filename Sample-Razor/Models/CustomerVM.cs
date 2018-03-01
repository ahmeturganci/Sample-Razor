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
    public class UserView
    {
        //[Display(Name = "User_Id")]
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phoneNo { get; set; }
    }
    public class LoginView
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class RegisterView
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
