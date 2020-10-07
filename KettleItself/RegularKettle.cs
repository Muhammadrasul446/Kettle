using System;
using System.Collections.Generic;
using System.Threading;
using Kettle.Providers.EnergySupplement;
using Kettle.Providers.LiquidSupplement;

namespace Kettle.KettleItself
{
    public class RegularKettle : IKettle
    {
        protected CapacityUnit LiquidLevel { get; set; }
        public Utensil Utensil { get; set; }
        public Boiler Boiler { get; set; }
        public List<IEnergy> WorksOn { get; set; }

        public virtual void Prepare()
        {
            Boiler.PutInto(Utensil);
        }

        public void Fill(ILiquid liquid, CapacityUnit capacity)
        {
            if (Utensil.Capacity.Value - LiquidLevel.Value <= capacity.Value)
                throw new ArgumentException("Liquid capacity cannot exceed kettle capacity!");
            LiquidLevel.Value += capacity.Value;
        }

        public void Boil()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Boiling {{i}}%...");
                Thread.Sleep(1000);
            }
        }
        public virtual void PourOut()
        {
            Console.WriteLine("Poured Out...");
            LiquidLevel.Value = 0;
        }
    }
}