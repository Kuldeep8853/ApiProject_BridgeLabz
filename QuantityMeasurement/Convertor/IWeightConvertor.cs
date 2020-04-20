using Model.WeightModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor
{
    public interface IWeightConvertor
    {
        double KgToGm(double kg);
        double GmToKg(double gm);
    }
}
