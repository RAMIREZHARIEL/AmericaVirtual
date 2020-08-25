using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_AmericaVirtual.Models
{
    public class Weather
    {
        private String state { get; set; }
        private String rainfall { get; set; }
        private float humidity { get; set; }
        private float wind { get; set; }
        private float degreesCelsius { get; set; }
        private float degreesFahrenheit { get; set; }
    }
}