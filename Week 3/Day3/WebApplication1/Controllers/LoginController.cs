using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult submit(UserLogin login)
        {

            ViewBag.Email = login.email;
            ViewBag.Password = login.password;
            if (login.email == "admin" || login.password == "admin") { 

            return View();
            }

            else
            {
                return View("welcome");
            }

        }

        
    }
}