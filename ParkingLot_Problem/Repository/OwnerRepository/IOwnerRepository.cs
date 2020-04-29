using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.OwnerRepository
{
    public interface IOwnerRepository
    {
        IEnumerable<Parking> GetAll();
        Task<int> Parkking(Parking parking);
        void UnParking(long ParkingSlotId);
    }
}
