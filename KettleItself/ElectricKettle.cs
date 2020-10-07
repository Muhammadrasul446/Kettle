using System;
using System.Threading;
using Kettle.Providers.EnergySupplement;

namespace Kettle.KettleItself
{
    public class ElectricKettle : RegularKettle, IElectricKettle
    {
        private bool IsOn { get; set; }
        public override void Prepare()
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
    }
}