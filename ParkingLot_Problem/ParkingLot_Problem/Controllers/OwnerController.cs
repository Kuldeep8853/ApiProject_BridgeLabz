using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.OwnerManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ParkingLot_Problem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly Sender sender = new Sender();
        private readonly IOwnerManager ownerManager;

        public OwnerController(IOwnerManager ownerManager)
        {
            this.ownerManager = ownerManager;
        }

        [Route("AllParkingDetails")]
        [HttpGet]
        public IEnumerable<Parking> GetAll()
        {
            return ownerManager.GetAll();
        }

        [Route("ParkVahical")]
        [HttpPost]
        public async Task<IActionResult> Parking_Vahical(Parking parking)
        {
            object result = await this.ownerManager.Parkking(parking);
            sender.Send(result);
                if (result != null)
                    return this.Ok(parking);

                return this.BadRequest();
        }

        [Route("UnParkVahical")]
        [HttpDelete]
        public string UnParking_Vahical(int ParkingSlotId)
        {
            string result = this.ownerManager.UnParking(ParkingSlotId);
            sender.Send(result);
            return result;
        }
    }
}