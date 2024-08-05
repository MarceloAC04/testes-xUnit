using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperatura
{
    public static class Temperatura
    {
        public static double Celsius { get; set; }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }
    }
}
