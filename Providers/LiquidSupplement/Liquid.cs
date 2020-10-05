namespace Kettle.Providers.LiquidSupplement
{
    public class Liquid : ILiquid
    {
        public string Name { get; set; }

        public Liquid(string name) => Name = name;
        public bool IsBoilable() => Name == "Water";
    }
}