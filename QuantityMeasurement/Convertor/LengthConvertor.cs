using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor
{
    public class LengthConvertor : ILengthConvertor
    {
        private readonly ILengthRepository lengthRepository;

        public LengthConvertor(ILengthRepository lengthRepository)
        {
            this.lengthRepository = lengthRepository;
        }
        public double FeetToInche(double feet)
        {
            return lengthRepository.FeetToInche(feet);
        }

        public double IncheToFeet(double inch)
        {
            return lengthRepository.IncheToFeet(inch);
        }
    }
}
