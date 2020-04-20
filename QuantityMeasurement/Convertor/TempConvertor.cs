using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor
{
    public class TempConvertor : ITempConvertor
    {
        private readonly ITempRepository tempRepository;

        public TempConvertor(ITempRepository tempRepository)
        {
            this.tempRepository = tempRepository;
        }
        public double CelciusToFahrenheit(double celcius)
        {
            return tempRepository.CelciusToFahrenheit(celcius);
        }

        public double FahrenheitToCelcius(double fahrenheit)
        {
            return tempRepository.FahrenheitToCelcius(fahrenheit);
        }
    }
}
