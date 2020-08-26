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
            User newUser =  UserServices.SearchUser(user, password);
            if (newUser != null)
            {
                ViewBag.Username = newUser.mail;

            }
            else{
                Response.Write("<script>alert('Error al loguearse. Se redireccionara a la pagina de inicio.')</script>");

            }
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult Register(String user, String password)
        {
            User newUser = new User(user,password);
            if (UserServices.InsertUser(newUser))
            {
                Response.Write("<script>alert('Registrado con exito! Ingrese al sistema!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al registrarse. Se redireccionara a la pagina de inicio.')</script>");
            }
            return View("~/Views/Home/Index.cshtml");
        }
        
    }
}
