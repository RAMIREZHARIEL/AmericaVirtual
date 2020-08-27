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
            ViewBag.Username = collection["user"];
            ViewBag.CountrySelected = collection["CountrySelected"];
            return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public ActionResult WeatherSearch(FormCollection collection)
        {
            ViewBag.Username = collection["user"];
            ViewBag.CountrySelected = collection["CountrySelected"];
            ViewBag.CitySelected = collection["CitySelected"];
            var Forecast = ZoneServices.SearchWeather(ViewBag.CitySelected);
            for (int i = 0; i < 8; i++)
            {
                String urlIcon = "http://openweathermap.org/img/wn/" + Forecast.daily[i].weather[0].icon + ".png";
                Forecast.daily[i].weather[0].icon = urlIcon;
            }
            ViewBag.Forecast = Forecast;
            return View("~/Views/Home/Index.cshtml");
        }




    }
}
