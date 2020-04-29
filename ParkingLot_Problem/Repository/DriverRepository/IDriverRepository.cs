using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DriverRepository
{
    public interface IDriverRepository
    {
        Task<int> Parkking(Parking parking);
        string UnParking(int ParkingSlotId);
    }
}
