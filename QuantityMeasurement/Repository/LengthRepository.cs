using Model.LengthModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class LengthRepository : ILengthRepository
    {
        public double FeetToInche(double Feet)
        {
            return Feet * 12.0;
        }

        public double IncheToFeet(double inch)
        {
            return inch/ 12;
        }
    }
}
