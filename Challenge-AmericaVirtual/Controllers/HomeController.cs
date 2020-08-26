using Challenge_AmericaVirtual.Models;
using Challenge_AmericaVirtual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Challenge_AmericaVirtual.Controllers
{


    

    [RoutePrefix("Home")]
    [Route("{Action}")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("Index")]
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Username = null;
            ViewBag.CountrySelected = null;
            return View();
        }

        

        [HttpPost]
        public ActionResult Index(String user, String password)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }






    }
}