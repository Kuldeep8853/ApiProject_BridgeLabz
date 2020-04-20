using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor
{
    public class WeightConvertor : IWeightConvertor
    {
        private readonly IWeightRepository weightRepository;

        public WeightConvertor(IWeightRepository weightRepository)
        {
            this.weightRepository = weightRepository;
        }
        public double GmToKg(double gm)
        {
            return weightRepository.GmToKg(gm);
        }

        public double KgToGm(double kg)
        {
            return weightRepository.KgToGm(kg);
        }
    }
}
