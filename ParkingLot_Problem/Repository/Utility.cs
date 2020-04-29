using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Utility
    {
        public static string Receipt(int PerHourCharge, DateTime EntryTime)
        {
            TimeSpan TotalTime = TimeSpan.FromTicks(DateTime.Now.Ticks - EntryTime.Ticks);
            int Hours = TotalTime.Hours;
            double Minutes = TotalTime.Minutes / 60;
            double Amount = (double)(Hours + Minutes) * PerHourCharge;
            if (PerHourCharge > Amount)
                Amount = PerHourCharge;

            return ("Parking Entry Time = " + EntryTime + "@\n" + "Parking Exit Time = " + DateTime.Now + "@\n" + "Parking Charges = " + Amount);
        }
    }
}
