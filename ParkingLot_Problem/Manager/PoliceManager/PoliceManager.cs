using Model;
using Repository.PoliceRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.PoliceManager
{
    public class PoliceManager : IPoliceManager
    {
        private readonly IPoliceRepository policeRepository;

        public PoliceManager(IPoliceRepository policeRepository)
        {
            this.policeRepository = policeRepository;
        }

        public Task<int> Parkking(Parking parking)
        {
           return this.policeRepository.Parkking(parking);
        }

        public string UnParking(int parkingSlotId)
        {
            return this.policeRepository.UnParking(parkingSlotId);
        }
    }
}
