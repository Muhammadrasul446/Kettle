using Kettle.Providers.EnergySupplement;

namespace Kettle.KettleItself
{
    public interface IElectricKettle : IKettle
    {
        public void TurnOff();
    }
}