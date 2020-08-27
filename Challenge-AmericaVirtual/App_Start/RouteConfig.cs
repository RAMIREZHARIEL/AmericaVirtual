using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Challenge_AmericaVirtual
{
    public class RouteConfig
    {
        
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "WeatherSearch",
            url: "WeatherSearch",
            defaults: new { controller = "Zone", action = "WeatherSearch", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "CountrySelect",
             url: "CountrySelect/{id}",
             defaults: new { controller = "Zone", action = "Country", id = "{id}" }
            );

            routes.MapRoute(
            name: "CitySelect",
            url: "CitySelect",
            defaults: new { controller = "Zone", action = "City", id = UrlParameter.Optional }
            );


            routes.MapRoute(
               name: "Logout",
               url: "Logout",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );


            routes.MapRoute(
                name: "Login",
                url: "Login",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

         



            routes.MapRoute(
                name: "Register",
                url: "Register",
                defaults: new { controller = "Account", action = "Register", id = UrlParameter.Optional }
            );



            routes.MapRoute(
                name: "Index",
                url: "Home/Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

          

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
