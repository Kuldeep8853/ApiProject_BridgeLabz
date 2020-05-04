using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.SecurityManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ParkingLot_Problem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityManager securityManager;

        public SecurityController(ISecurityManager securityManager)
        {
            this.securityManager = securityManager;
        }

        [Route("ParkVahical")]
        [HttpPost]
        public async Task<IActionResult> Parking_Vahical(Parking parking)
        {
            object result = await this.securityManager.Parkking(parking);
            if (result != null)
                return this.Ok(parking);

            return this.BadRequest();
        }

        [Route("CheckParkingOpen_Full")]
        [HttpGet]
        public string Check_Parking_Open_Full()
        {
            string result= this.securityManager.Check_Parking_Open_Full();
            return result;
        }

        [Route("UnParkVahical")]
        [HttpDelete]
        public string UnParking_Vahical(int ParkingSlotId)
        {
            string result = this.securityManager.UnParking(ParkingSlotId);
            return result;
        }
    }
}