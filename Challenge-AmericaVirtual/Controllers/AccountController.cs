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
             
        public ActionResult Login(String user, String password)
        {
            User newUser = new User();
            newUser = UserServices.SearchUser(user, password);
            if (newUser != null)
            {
                ViewBag.Username = newUser.mail;
            }
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult Register(String user, String password)
        {
            User newUser = new User();
            newUser.mail = user;
            newUser.password = password;
            if (UserServices.InsertUser(newUser))
            {
                Response.Write("<script>alert('Registrado con exito! ')</script>");
            }
            return View("~/Views/Home/Index.cshtml");



        }
        
    }
}
