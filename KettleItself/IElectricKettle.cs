using Kettle.Providers.EnergySupplement;

namespace Kettle.KettleItself
{
    public interface IElectricKettle : IKettle
    {
        public void TurnOn(IEnergy energy);
        public void TurnOff();
    }
}