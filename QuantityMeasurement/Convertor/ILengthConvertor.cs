using Model.LengthModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor
{
    public interface ILengthConvertor
    {
        double FeetToInche(double feet);

        double IncheToFeet(double inch);
    }
}
