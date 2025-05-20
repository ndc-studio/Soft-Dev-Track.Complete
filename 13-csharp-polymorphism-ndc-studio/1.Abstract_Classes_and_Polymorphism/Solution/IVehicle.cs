namespace VehicleSpace
{
    public interface IVehicle
    {
        void Start();
    }
    
    public abstract class Vehicle : IVehicle
    {
        public abstract void Start();
    }
}