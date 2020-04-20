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
    public class WeightController : ControllerBase
    {
        private readonly IWeightConvertor weightConvertor;

        public WeightController(IWeightConvertor weight)
        {
            this.weightConvertor = weight;
        }

        [Route("api/KgToGm")]
        [HttpGet]
        public async Task<IActionResult> GetFeet(double kg)
        {
            var result= weightConvertor.KgToGm(kg);
            if(result!=0.0)
                return Ok(result);

            return this.BadRequest();
        }

        [Route("api/GmToKg")]
        [HttpGet]
        public async Task<IActionResult> GetInch(double gm)
        {
            var result= weightConvertor.GmToKg(gm);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}