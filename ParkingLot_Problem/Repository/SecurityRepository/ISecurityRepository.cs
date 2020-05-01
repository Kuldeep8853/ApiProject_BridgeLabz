using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.SecurityRepository
{
    public interface ISecurityRepository
    {
        Task<int> Parkking(Parking parking);
        string UnParking(int ParkingSlotId);
    }
}
