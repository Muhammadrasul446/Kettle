using Kettle.KettleItself;

namespace Kettle.Runner
{
    public interface IRunner
    {
        public void GetEnergy();
        public void GetWater();
        public void BoilWater(CapacityUnit capacity);
    }
}