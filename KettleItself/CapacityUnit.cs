namespace Kettle.KettleItself
{
    public class CapacityUnit
    {
        public int Value { get; set; }

        public CapacityUnit(int value)
        {
            Value = value;
        }
        
        public double ToMilliliters() => Value / 1000.0;
    }
}