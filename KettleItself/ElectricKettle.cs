using System;
using System.Threading;
using Kettle.Providers.EnergySupplement;

namespace Kettle.KettleItself
{
    public class ElectricKettle : RegularKettle, IElectricKettle
    {
        private bool IsOn { get; set; }
        public void TurnOn(IEnergy energy)
        {
            Boiler.Plug();
            Boiler.PutInto(Utensil);
            IsOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Electric Kettle turned off...");
            Boiler.UnPlug();
        }


        public override void PourOut()
        {
            base.PourOut();
            
        }
    }
}