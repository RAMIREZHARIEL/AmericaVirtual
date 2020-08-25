using Challenge_AmericaVirtual.Models;
using Challenge_AmericaVirtual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Challenge_AmericaVirtual.Controllers
{
    public class AccountController : Controller
    {
        
        public ActionResult Register()
        {
            return View();
        }

       
        public ActionResult Login(String user, String password)
        {
            User newUser = new User();
            newUser = UserServices.SearchUser(user, password);
            if (newUser != null)
            {
                ViewBag.Username = newUser.mail;
                return View("~/Views/Home/Index.cshtml");
            }
           
             return null;
            

        }
        
    }
}
