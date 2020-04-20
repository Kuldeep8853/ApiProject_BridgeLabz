using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Convertor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.TempratureModel;

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
        public async Task<IActionResult> GetFahrenheit(double celcious)
        {
            var result= tempConvertor.CelciusToFahrenheit(celcious);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }

        [Route("api/FahrenheitToCelcius")]
        [HttpGet]
        public async Task<IActionResult> GetCelcius(double fahrenheit)
        {
            var result= tempConvertor.FahrenheitToCelcius(fahrenheit);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}