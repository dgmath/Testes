using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temperatura
{
    public static class ConversorTemperatura
    {
        //Formula : (0 °C × 9/5) + 32 = 32 °F

        //método estático 
        public static float CelsiusToFahrenheit(float celsius)
        {
            float temperatura = celsius;
            
           float fahrenheit = (temperatura * 1.8f) + 32;

           return fahrenheit;
        }

        //Formula : (0 °F − 32) × 5/9 = -17,78 °C

        //método estático 
        public static float FahrenheitToCelsius(float fahrenheit)
        {
            float temperatura = fahrenheit;
            
           float celsius = ((temperatura - 32) * 5/9) ;

           return celsius;
        }
    }
}