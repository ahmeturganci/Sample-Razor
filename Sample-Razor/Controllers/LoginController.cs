﻿using Model.Models;
using Sample_Razor.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_Razor.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(CustomerVM user)
        {
            var response = BusinessLayer.Login(user);
            if( response == true)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View("Login");
            }

        }


        public ActionResult Register()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Register(CustomerVM user)
        {
            var response = BusinessLayer.Register(user);
            if (response)
            {
                return View("Product/Index");
            }
            else
            {
                return View("Register");
            }
            

        }
       
    }
}
