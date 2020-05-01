using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.SecurityManager
{
    public interface ISecurityManager
    {
        Task<int> Parkking(Parking parking);
        string UnParking(int parkingSlotId);
    }
}
