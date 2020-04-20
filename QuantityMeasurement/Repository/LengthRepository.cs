using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class LengthRepository: ILengthRepository
    {
        public double FeetToInche(double feet)
        {
            return feet * 12;
        }

        public double IncheToFeet(double inch)
        {
            return inch/ 12;
        }

    }
}
