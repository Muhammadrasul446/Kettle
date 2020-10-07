using System;
using System.Collections.Generic;
using Kettle.KettleItself;
using Kettle.Providers.EnergySupplement;
using Kettle.Providers.LiquidSupplement;

namespace Kettle
{
    class Program
    {
        static void Main(string[] args)
        {
            var liquids = new List<ILiquid>() { new Liquid("Water"), new Liquid("Fuel")};
            var liquidProvider = new LiquidProvider(liquids);

            var energies = new List<IEnergy>() {new Energy("Electricity"), new Energy("SomethingElse")};
            var energyProvider = new EnergyProvider(energies);

            var regularKettle = new RegularKettle();
            var electricKettle = new ElectricKettle();
            
            var capacity = new CapacityUnit(100);
            var utensil = new Utensil("Kettle", capacity);
            var boiler = new Boiler("Кипятильник");

            regularKettle.Utensil = utensil;
            regularKettle.Boiler = boiler;
            regularKettle.WorksOn = energies;

            electricKettle.Utensil = utensil;
            electricKettle.Boiler = boiler;
            electricKettle.WorksOn = energies;

            var regularKettleRunner = new Runner.Runner(liquidProvider, energyProvider, regularKettle);
            var electricKettleRunner = new Runner.Runner(liquidProvider, energyProvider, electricKettle);
        }
    }

}