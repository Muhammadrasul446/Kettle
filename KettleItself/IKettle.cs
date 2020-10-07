using Kettle.Providers.LiquidSupplement;

namespace Kettle.KettleItself
{
    public interface IKettle
    {
        public void Prepare();
        public void Fill(ILiquid liquid, CapacityUnit capacity);
        public void Boil();
        public void PourOut();
    }
}