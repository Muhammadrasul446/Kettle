using Kettle.KettleItself;

namespace Kettle.Providers.EnergySupplement
{
    public class Energy : IEnergy
    {
        public string Name { get; set; }

        public Energy(string name) => Name = name;
        public bool IsCompatibleWith(RegularKettle kettle) => kettle.WorksOn.Contains(this);
    }
}