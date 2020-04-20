using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor
{
    public interface ITempConvertor
    {
        double CelciusToFahrenheit(double celcius);
        double FahrenheitToCelcius(double fahrenheit);
    }
}
