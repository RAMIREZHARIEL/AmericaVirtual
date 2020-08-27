using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_AmericaVirtual.Models
{
    public class City
    {
        public String countryCode { get; set; }
        public int id { get; set; }
        public String name { get; set; }

        public class Coord
        {
            public double lat { get; set; }
            public double lon { get; set; }
        }

        public class Result
        {
            public Coord coord { get; set; }
        }
    }
}