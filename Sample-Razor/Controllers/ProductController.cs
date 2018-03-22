using Model.Models;
using Sample_Razor.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_Razor.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var response = new ProductVM();
            response.ProductList = BusinessLayer.GetAllProducts().ToList();
            return View(response);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductVM product)
        {
            var response = BusinessLayer.AddProduct(product.Product);
            if (response)
            {
                return View("Index");
            }
            else
            {
                return View("Error");
            }
        }


        //public ActionResult Edit(int? id)
        //{

        //    return View();


        //}

        //[HttpPost]
        //public ActionResult Edit(ProductVM product)
        //{
        //    var response = BusinessLayer.EditProduct(id);
        //    if (response)
        //    {
        //        return View("List");
        //    }
        //    else
        //    {
        //        return View("ERROR");
        //    }
        //}

        public ActionResult Edit(int? id)
        {
            
            ProductVM p = new ProductVM();
            var eProduct = BusinessLayer.GetProduct((int)id);
           
            p.Product = eProduct;
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(ProductVM product)
        {
            ProductVM tempProduct = new ProductVM();
            if (product.Product.id== null)
            {
                //add new product
                BusinessLayer.AddProduct(product.Product);
                return Redirect("Index");
            }
            else
            {
                BusinessLayer.EditProduct(product.Product);

            }
            return View();
        }       



        public ActionResult DeleteProduct(int? id)
        {
            var response = BusinessLayer.DeleteProduct(id);
            if (response)
            {
                return View("Index");
            }
            else
            {
                return View("Not Success");
            }

        }

    }
}