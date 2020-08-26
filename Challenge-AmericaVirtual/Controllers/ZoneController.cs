using Challenge_AmericaVirtual.Models;
using Challenge_AmericaVirtual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Challenge_AmericaVirtual.Controllers
{
    public class ZoneController : Controller
    {
        [HttpPost]
        public ActionResult Country()
        {
            
            return View("~/Views/Home/Index.cshtml");
        }



        [HttpPost]
        public ActionResult City(FormCollection collection)
        {
            ViewBag.CountrySelected = collection["CountrySelected"];
            return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public ActionResult WeatherSearch(FormCollection collection)
        {
            ViewBag.CitySelected = collection["CitySelected"];
            var wheater = ZoneServices.SearchWeather("a", 1);
            return View("~/Views/Home/Index.cshtml");
        }




    }
}
