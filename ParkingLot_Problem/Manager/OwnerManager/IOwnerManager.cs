using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.OwnerManager
{
    public interface IOwnerManager
    {
        IEnumerable<Parking> GetAll();
        Task<int> Parkking(Parking parking);
        string UnParking(int ParkingSlotId);
    }
}
