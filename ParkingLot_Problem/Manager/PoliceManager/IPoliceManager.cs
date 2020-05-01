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
        string UnParking(int parkingSlotId);
    }
}
