using System;

namespace Kettle.KettleItself
{
    public class Boiler : IBoiler
    {
        private string Name { get; }
        public bool IsPlugged { get; set; }
        private Utensil Utensil { get; set; }

        public Boiler(string name)
        {
            Name = name;
            IsPlugged = false;
        }
        
        public void Plug()
        {
            if (IsPlugged) throw new Exception("Boiler already Plugged");
        }

        public void PutInto(Utensil utensil)
        {
            Utensil = utensil;
        }

        public void UnPlug()
        {
            IsPlugged = false;
        }
    }
}