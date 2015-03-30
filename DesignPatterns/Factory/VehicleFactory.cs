using DesignPatterns.Factory.Vehicles;

namespace DesignPatterns.Factory
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(VehicleType type)
        {
            if (type == VehicleType.Car)
            {
                return new Car();
            }
            else if (type == VehicleType.Truck)
            {
                return new Truck();
            }
            else if (type == VehicleType.Motorcycle)
            {
                return new Motorcycle();
            }

            return new Bicycle();
        }
    }
}
