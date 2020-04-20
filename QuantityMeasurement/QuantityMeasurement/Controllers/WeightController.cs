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
        public ActionResult<double> GetFeet(double kg)
        {
            return weightConvertor.KgToGm(kg);
        }

        [Route("api/GmToKg")]
        [HttpGet]
        public ActionResult<double> GetInch(double gm)
        {
            return weightConvertor.GmToKg(gm);
        }
    }
}