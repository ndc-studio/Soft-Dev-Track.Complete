namespace VehicleSpace
{
    public interface IVehicle
    {
        string Start();
    }
    
    public abstract class Vehicle : IVehicle
    {
        public abstract string Start();
    }
}