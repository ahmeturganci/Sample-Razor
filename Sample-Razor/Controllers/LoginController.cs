using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_Razor.Controllers
{
    public class LoginController : Controller
    {

        DemoCtsContext db = new DemoCtsContext();//database connection expression

        /// <summary>
        /// Login page view
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Login View
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Login Page post status
        /// </summary>
        /// <param name="user">login param email and password</param>
        /// <returns>successe-> TRUE else notfound page</returns>
        [HttpPost]
        public ActionResult Login(CustomerVM user)// WHY NOT WORKING LoginUserView say selçuk
        {
            var wantLogin = db.Customers
                  .Where(z => z.email == user.Customer.email && z.password == user.Customer.password)
                  .FirstOrDefault();

            if (wantLogin == null)
            {
                return HttpNotFound();
            }
            else
            {
                return Redirect("/Home/Index");
            }

        }

        /// <summary>
        /// register view
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();

        }

        /// <summary>
        /// Register page post statu
        /// </summary>
        /// <param name="user">Register post param email,name,surname,password</param>
        /// <returns>successe-> TRUE else notfound page</returns>
        [HttpPost]
        public ActionResult Register(CustomerVM user)
        {
            using (DemoCtsContext db = new DemoCtsContext())
            {
                //var cus = (from k in db.Customers
                //           where k.email == customer.email
                //           select k).SingleOrDefault(); --> LINQ

                var cus = db.Customers
                            .Where(x => x.email == user.Customer.email)
                            .SingleOrDefault();
                if (cus == null)
                {
                    //Added try catch
                    db.Customers.Add(user.Customer);
                    db.SaveChanges();
                    return Redirect("Login");

                }
                else
                    return View("Kayıt Başarısız");

            }

        }
    }
}
