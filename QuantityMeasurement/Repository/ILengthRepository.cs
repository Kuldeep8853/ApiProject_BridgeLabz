using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ILengthRepository
    {
        double FeetToInche(double feet);

        double IncheToFeet(double inch);
    }
}
