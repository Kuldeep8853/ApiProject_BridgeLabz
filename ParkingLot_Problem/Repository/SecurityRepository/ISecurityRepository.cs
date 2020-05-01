﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SecurityRepository
{
    public interface ISecurityRepository
    {
        Task<int> Parkking(Parking parking);
        string UnParking(int ParkingSlotId);
    }
}
