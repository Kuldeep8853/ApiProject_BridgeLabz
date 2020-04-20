using Model.TempratureModel;
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

        public double FahrenheitToCelcius(double fahrenhit)
        {
            return fahrenhit- 32 * 5 / 9;
        }
    }
}
