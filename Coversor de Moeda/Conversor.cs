using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coversor_de_Moeda
{
    public static class Conversor
    {
        
        public static float Dolar { get; set; } = 4.99f;

        public static float Real { get; set; } = 1;

        public static float ConverterDolaremReal(float Dolar)
        {
            float Moeda = Dolar;

            Real = Moeda / 0.20f;
            return Real;
        }
        public static float ConverterRealemdolar(float Real)
        {
            float Moeda = Real;

            Dolar = Moeda / Dolar;
            return Dolar;
        }


    }
}