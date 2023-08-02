using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            return (fTemp - 32) / 1.8; 
        }
        public static double CelsiusToFahrenheit(double cTemp)
        {
            return (cTemp * 1.8) + 32;
        }

    }
}
