using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TempRepository : ITempRepository
    {
        public double CelciusToFahrenheit(double celcius)
        {
            return celcius * 9 / 5 + 32;
        }

        public double FahrenheitToCelcius(double fahrenhite)
        {
            return ((fahrenhite - 32) * 5 / 9);
        }
    }
}
