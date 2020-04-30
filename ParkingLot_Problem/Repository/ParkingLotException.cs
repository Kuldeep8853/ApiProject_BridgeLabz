using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    [System.Serializable]
    public class ParkingLotException : Exception
    {
        public string mgs;

        public ParkingLotException(string mgs)
        {
            this.mgs = mgs;
        }
    }
}
