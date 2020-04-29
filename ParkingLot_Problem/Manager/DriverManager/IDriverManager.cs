using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.DriverManager
{
    public interface IDriverManager
    {
        Task<int> Parkking(Parking parking);
        void UnParking(long parkingSlotId);
    }
}
