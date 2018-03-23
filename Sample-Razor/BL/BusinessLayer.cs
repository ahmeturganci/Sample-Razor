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

        public static Product GetProduct(int id)
        {
            var proc = db.Products.First(x => x.id == id);
            return proc;
        }

        public static IEnumerable<Product> GetAllProducts()
        {
            var productList = db.Products
                                    .Where(x => x.id != null).ToList();
            if (productList != null) // Bu if niye var ve ne iş yapar :)
            {
                return productList;
            }
            else
            {
                return null;
            }
        }

        public static bool AddProduct(Product product)
        {
            var tempAddProduct = db.Products
                                   .Where(x => x.name == product.name)
                                   .FirstOrDefault();
            if (tempAddProduct == null)
            {
                db.Products.Add(tempAddProduct);
                db.SaveChanges();
                return true;
                // Kayıt sırasında beklenmedik bir hata olabilir. try catch kullanılsa iyi olur.
            }
            else
            {
                return false;
            }

        }

        public static bool EditProduct(Product proc)
        {
            var tempProc = db.Products
                             .Where(x => x.id == proc.id)
                             .FirstOrDefault();

            if (tempProc != null)
            {
                Product temp = new Product
                {
                    name = tempProc.name,
                    description = tempProc.description
                };
                db.SaveChanges();
                return true;
                // Burada herhangi bir güncelleme işlemi yapıldığına emin değilim :)
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
