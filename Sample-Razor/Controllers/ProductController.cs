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
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var response = BusinessLayer.GetAllProducts();
            if (response != null)
            {
                return View(response);
            }
            else
            {
                return View("No Product");
            }
        }
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(ProductVM product)
        {
            var response = BusinessLayer.AddProduct(product);
            if (response)
            {
                return View("Index");
            }
            else
            {
                return View("Error");
            }
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