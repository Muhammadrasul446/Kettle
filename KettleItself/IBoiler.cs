namespace Kettle.KettleItself
{
    public interface IBoiler
    {
        public void Plug();
        public void PutInto(Utensil utensil);
        public void UnPlug();
    }
}