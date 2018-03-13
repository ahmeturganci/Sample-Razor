using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample_Razor.BL
{
    public static class BusinessLayer
    {

        public static DemoCtsContext db = new DemoCtsContext();

        public static bool Login(CustomerVM customer)
        {

            var wantLogin = db.Customers
             .Where(z => z.email == customer.Customer.email && z.password == customer.Customer.password)
             .FirstOrDefault();

            if (wantLogin != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Register(CustomerVM customer)
        {
            var cus = db.Customers
                           .Where(x => x.email == customer.Customer.email)
                           .SingleOrDefault();
            if (cus == null)
            {
                db.Customers.Add(customer.Customer);
                db.SaveChanges();
                return true;

            }
            else
                return false;

        }


        public static List<Customer> GetAllProducts()
        {
            var customerList = db.Customers.ToList();
            if (customerList != null)
            {
                return customerList;
            }
            else
            {
                return null;
            }
        }

        public static bool AddProduct(ProductVM product)
        {
            var tempAddProduct = db.Products
                                   .Where(x => x.name == product.Product.name)
                                   .FirstOrDefault();
            if (tempAddProduct != null)
            {
                db.Products.Add(tempAddProduct);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool DeleteProduct(int? id)
        {
            var dProduct = db.Products
                               .First(x => x.id == id);
            if (dProduct != null)
            {
                db.Products.Remove(dProduct);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
