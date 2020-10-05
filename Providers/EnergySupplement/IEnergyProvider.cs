using Kettle.KettleItself;

namespace Kettle.Providers.EnergySupplement
{
    public interface IEnergyProvider
    {
        public IEnergy GetEnergyFor(IKettle kettle);
    }
}