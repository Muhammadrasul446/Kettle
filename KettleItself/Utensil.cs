namespace Kettle.KettleItself
{
    public class Utensil
    {
        public string Name { get; set; }

        public CapacityUnit Capacity { get; set; }

        public Utensil(string name, CapacityUnit capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
}