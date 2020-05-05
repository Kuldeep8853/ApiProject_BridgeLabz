using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.DriverManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;

namespace ParkingLot_Problem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly Sender sender = new Sender();
        private readonly IDriverManager driverManager;

        public DriverController(IDriverManager driverManager)
        {
            this.driverManager = driverManager;
        }

        [Route("ParkVahical")]
        [HttpPost]
        public async Task<IActionResult> Parking_Vahical(Parking parking)
        {
            object result = await this.driverManager.Parkking(parking);
            sender.Send("Vahical parked");
            if (result != null)
                return this.Ok(parking);

            return this.BadRequest();
        }

        [Route("UnParkVahical")]
        [HttpDelete]
        public string UnParking_Vahical(int ParkingSlotId)
        {
            string result = this.driverManager.UnParking(ParkingSlotId);
            sender.Send("UnParked the Vahical");
            return result;
        }
    }
}