using System.Collections.Generic;

namespace Kettle.Providers.LiquidSupplement
{
    public class LiquidProvider : ILiquidProvider
    {
        public List<ILiquid> AvailableLiquids { get; set; }

        public LiquidProvider(List<ILiquid> availableLiquids) => AvailableLiquids = availableLiquids;

        public ILiquid GetLiquid()
        {
            return AvailableLiquids[0];
        }
    }
}