﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.PoliceManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ParkingLot_Problem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliceController : ControllerBase
    {
        private readonly IPoliceManager policeManager;

        public PoliceController(IPoliceManager policeManager)
        {
            this.policeManager = policeManager;
        }

        [Route("ParkVahical")]
        [HttpPost]
        public async Task<IActionResult> Parking_Vahical(Parking parking)
        {
            object result = await this.policeManager.Parkking(parking);
            if (result != null)
                return this.Ok(parking);

            return this.BadRequest();
        }

        [Route("UnParkVahical")]
        [HttpDelete]
        public string UnParking_Vahical(int ParkingSlotId)
        {
            string result = this.policeManager.UnParking(ParkingSlotId);
            return result;
        }
    }
}