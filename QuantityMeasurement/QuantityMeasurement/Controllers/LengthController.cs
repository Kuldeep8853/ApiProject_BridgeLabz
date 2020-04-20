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
    public class LengthController : ControllerBase
    {
        private ILengthConvertor lengthConvertor;

        public LengthController(ILengthConvertor length)
        {
            this.lengthConvertor = length;
        }

        [Route("api/InchToFeet")]
        [HttpGet]
        public ActionResult<double> GetFeet(double inch)
        {
            return lengthConvertor.IncheToFeet(inch);
        }

        [Route("api/FeetToInch")]
        [HttpGet]
        public ActionResult<double> GetInch(double feet)
        {
            return lengthConvertor.FeetToInche(feet);
        }
    }
}