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

        public IEnumerable<Parking> GetDetails_Color(string color)
        {
            return this.policeRepository.GetDetails_Color(color);
        }

        public IEnumerable<Parking> GetDetails_BrandName(string BrandName)
        {
            return this.policeRepository.GetDetails_BrandName(BrandName);
        }
        public string UnParking(int parkingSlotId)
        {
            return this.policeRepository.UnParking(parkingSlotId);
        }
    }
}
