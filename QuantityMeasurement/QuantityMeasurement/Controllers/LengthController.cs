using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Convertor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.LengthModel;

namespace QuantityMeasurement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        private ILengthConvertor lengthConvertor;

        public LengthController(ILengthConvertor length)
        {
            this.lengthConvertor = length;
        }

        [Route("api/InchToFeet")]
        [HttpGet]
        public async Task<IActionResult> GetFeet(double inch)
        {
            var result= lengthConvertor.IncheToFeet(inch);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }

        [Route("api/FeetToInch")]
        [HttpGet]
        public async Task<IActionResult> GetInch(double feet)
        {
            var result= lengthConvertor.FeetToInche(feet);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}