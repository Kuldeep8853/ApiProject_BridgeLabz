using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class WeightRepository : IWeightRepository
    {
        public double GmToKg(double gm)
        {
            return gm /1000;
        }

        public double KgToGm(double kg)
        {
            return kg * 1000;
        }
    }
}
