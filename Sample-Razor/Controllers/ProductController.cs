using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Sample_Razor.Controllers
{
    public class ProductController : Controller
    {
        DemoCtsContext db = new DemoCtsContext();

        /// <summary>
        /// Product list page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// List all product 
        /// </summary>
        /// <returns>product list</returns>
        public ActionResult List()
        {
            var pList = new ProductVM();
            pList.ProductList = db.Products.ToList();
            return View(pList);
        }

        /// <summary>
        /// a product for edit information update
        /// </summary>
        /// <param name="id"> will be updated product id</param>
        /// <returns></returns>
        public ActionResult EditProduct(int? id)
        {
            ProductVM p = new ProductVM();
            
            if (id == null)
            {
                //
            }

            var eProduct = db.Products
                             .First(x => x.id == id);
            if (eProduct == null)
            {
                return HttpNotFound();
            }
            p.Product = eProduct;
            return View(p);
        }

        [HttpPost]
        public ActionResult EditProduct(int? id,ProductVM product)
        {
            ProductVM tempProduct = new ProductVM();
            if (id == null)
            {
                //add new product
                db.Products.Add(product.Product);
                db.SaveChanges();
                return Redirect("Index");
            }
            else
            {
                var updateProduct = db.Products.First(x => x.id == id);
                updateProduct.name = product.Product.name;
                updateProduct.description = product.Product.description;
                db.SaveChanges();

            }
            return View();
        }

        /// <summary>
        /// Delete for product
        /// </summary>
        /// <param name="id">will be deleted product id</param>
        /// <returns></returns>
        public ActionResult DeleteProduct(int? id)
        {
            var dProduct = db.Products
                             .First(x => x.id == id);
            if(dProduct != null)
            {
                db.Products.Remove(dProduct);
                db.SaveChanges();
                return View("Index");
            }
            else
            {
                return HttpNotFound("unsuccessful");
            }
                                        
        }

    }
}