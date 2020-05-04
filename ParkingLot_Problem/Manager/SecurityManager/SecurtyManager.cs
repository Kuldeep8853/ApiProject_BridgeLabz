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
        private readonly ISecurityRepository _securityRepository;

        public SecurtyManager(ISecurityRepository securityRepository)
        {
            this._securityRepository = securityRepository;
        }

        public Task<int> Parkking(Parking parking)
        {
           return this._securityRepository.Parkking(parking);
        }

        public string Check_Parking_Open_Full()
        {
            return this._securityRepository.Check_Parking_Open_Full();
        }
        public string UnParking(int parkingSlotId)
        {
           return this._securityRepository.UnParking(parkingSlotId);
        }
    }
}
