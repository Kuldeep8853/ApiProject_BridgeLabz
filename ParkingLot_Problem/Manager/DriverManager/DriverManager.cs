using Model;
using Repository.DriverRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.DriverManager
{
    public class DriverManager:IDriverManager
    {
        private readonly IDriverRepository driverRepository;

        public DriverManager(IDriverRepository driverRepository)
        {
            this.driverRepository = driverRepository;
        }

        public Task<int> Parkking(Parking parking)
        {
            return this.driverRepository.Parkking(parking);
        }

        public void UnParking(long parkingSlotId)
        {
            this.driverRepository.UnParking(parkingSlotId);
        }
    }
}
