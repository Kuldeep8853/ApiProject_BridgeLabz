using Model;
using Repository.OwnerRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.OwnerManager
{
    public class OwnerManager : IOwnerManager
    {
        private readonly IOwnerRepository ownerRepository;
        public OwnerManager(IOwnerRepository ownerRepository)
        {
            this.ownerRepository = ownerRepository;
        }

        public IEnumerable<Parking> GetAll()
        {
            return ownerRepository.GetAll();
        }

        public Task<int> Parkking(Parking parking)
        {
            return ownerRepository.Parkking(parking);
        }

        public string UnParking(int ParkingSlotId)
        {
            return ownerRepository.UnParking(ParkingSlotId);
        }
    }
}
