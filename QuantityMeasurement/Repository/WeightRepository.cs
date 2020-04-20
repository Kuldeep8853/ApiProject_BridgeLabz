using Model.WeightModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class WeightRepository : IWeightRepository
    {
        public double GmToKg(double gram)
        {
            return gram /1000;
        }

        public double KgToGm(double kilogram)
        {
            return kilogram * 1000;
        }
    }
}
