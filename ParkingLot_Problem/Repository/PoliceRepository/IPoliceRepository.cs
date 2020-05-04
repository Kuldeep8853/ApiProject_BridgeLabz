using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.PoliceRepository
{
    public interface IPoliceRepository
    {
        Task<int> Parkking(Parking parking);
        IEnumerable<Parking> GetDetails_Color(string color);
        IEnumerable<Parking> GetDetails_BrandName(string BrandName);
        string UnParking(int ParkingSlotId);
    }
}
