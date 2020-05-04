using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.PoliceManager
{
    public interface IPoliceManager
    {
        Task<int> Parkking(Parking parking);
        IEnumerable<Parking> GetDetails_Color(string color);
        IEnumerable<Parking> GetDetails_BrandName(string BrandName);
        string UnParking(int parkingSlotId);
    }
}
