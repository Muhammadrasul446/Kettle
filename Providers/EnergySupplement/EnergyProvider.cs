using System;
using System.Collections.Generic;
using Kettle.KettleItself;

namespace Kettle.Providers.EnergySupplement
{
    public class EnergyProvider : IEnergyProvider
    {
        public List<IEnergy> AvailableEnergy { get; set; }

        public EnergyProvider(List<IEnergy> availableEnergy) => AvailableEnergy = availableEnergy;

        public IEnergy GetEnergyFor(IKettle kettle)
        {
            for (int i = 0; i < AvailableEnergy.Count; i++)
            {
                if (AvailableEnergy[i].IsCompatibleWith(kettle)) return AvailableEnergy[i];
            }

            return null;
        }
    }
}