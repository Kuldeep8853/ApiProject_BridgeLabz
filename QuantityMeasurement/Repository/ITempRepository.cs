using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ITempRepository
    {
        double CelciusToFahrenheit(double celcius);
        double FahrenheitToCelcius(double fahrenheit);
    }
}
