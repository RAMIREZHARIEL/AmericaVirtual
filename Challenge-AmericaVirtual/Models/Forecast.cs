using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_AmericaVirtual.Models
{
    public class Forecast
    {


        public class Weather
        {

            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class Temp
        {
            public double day { get; set; }
            public double max { get; set; }
            public double min { get; set; }

        }


        public class Daily
        {
            public Temp temp { get; set; }
            public double wind_speed { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public double rain { get; set; }
            public List<Weather> weather { get; set; }
            public int dt { get; set; }
            public int cod { get; set; }
        }

        public class Result
        {
            public List<Daily> daily { get; set; }
        }

    }
}