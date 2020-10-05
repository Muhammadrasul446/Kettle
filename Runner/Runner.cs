using Kettle.KettleItself;
using Kettle.Providers.EnergySupplement;
using Kettle.Providers.LiquidSupplement;

namespace Kettle.Runner
{
    public class Runner : IRunner
    {
        private IEnergy _energy;
        private ILiquid _liquid;
        public ILiquidProvider LiquidProvider { get; set; }
        public IEnergyProvider EnergyProvider { get; set; }
        public IKettle Kettle { get; set; }

        public Runner(ILiquidProvider liquidProvider, IEnergyProvider energyProvider, IKettle kettle)
        {
            LiquidProvider = liquidProvider;
            EnergyProvider = energyProvider;
            Kettle = kettle;
        }
        public void GetEnergy()
        {
            _energy = EnergyProvider.GetEnergyFor(Kettle);
        }

        public void GetWater()
        {
            _liquid = LiquidProvider.GetLiquid();
        }

        public void BoilWater()
        {
            
        }
    }
}