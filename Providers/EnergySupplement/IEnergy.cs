using Kettle.KettleItself;

namespace Kettle.Providers.EnergySupplement
{
    public interface IEnergy
    {
        public bool IsCompatibleWith(IKettle kettle);
    }
}