using Model.WeightModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IWeightRepository
    {
        double KgToGm(double kg);
        double GmToKg(double gm);
    }
}
