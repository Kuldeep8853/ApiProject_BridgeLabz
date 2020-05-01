using Model;
using Repository.SecurityRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.SecurityManager
{
    public class SecurityManager : ISecurityManager
    {
        private readonly ISecurityRepository securityRepository;

        public SecurityManager(ISecurityRepository securityRepository)
        {
            this.securityRepository = securityRepository;
        }

        public Task<int> Parkking(Parking parking)
        {
           return this.Parkking(parking);
        }

        public string UnParking(int parkingSlotId)
        {
           return this.UnParking(parkingSlotId);
        }
    }
}
