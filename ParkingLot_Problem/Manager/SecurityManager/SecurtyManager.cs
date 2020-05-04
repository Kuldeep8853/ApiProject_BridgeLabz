using Model;
using Repository.SecurityRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.SecurityManager
{
    public class SecurtyManager : ISecurityManager
    {
        private readonly ISecurityRepository securityRepository;

        public SecurtyManager(ISecurityRepository securityRepository)
        {
            this.securityRepository = securityRepository;
        }

        public Task<int> Parkking(Parking parking)
        {
           return this.Parkking(parking);
        }

        public string Check_Parking_Open_Full()
        {
            return this.Check_Parking_Open_Full();
        }
        public string UnParking(int parkingSlotId)
        {
           return this.UnParking(parkingSlotId);
        }
    }
}
