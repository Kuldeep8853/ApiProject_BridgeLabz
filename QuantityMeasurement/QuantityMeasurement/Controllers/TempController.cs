using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Convertor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuantityMeasurement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        private readonly ITempConvertor tempConvertor;

        public TempController(ITempConvertor temperature)
        {
            this.tempConvertor = temperature;
        }

        [Route("api/CelciusToFahrenheit")]
        [HttpGet]
        public ActionResult<double> GetFahrenheit(double celcious)
        {
            return tempConvertor.CelciusToFahrenheit(celcious);
        }

        [Route("api/FahrenheitToCelcius")]
        [HttpGet]
        public ActionResult<double> GetCelcius(double fahrenheit)
        {
            return tempConvertor.FahrenheitToCelcius(fahrenheit);
        }
    }
}