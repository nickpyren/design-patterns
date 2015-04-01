using DesignPatterns.Helpers.Vehicles;

namespace DesignPatterns.Patterns.Factory
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(VehicleType type)
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
