using System;
using DesignPatterns.Helpers.Vehicles;
using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Observer;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Factory Example--------------------------\n");

            var vehicleFactory = new VehicleFactory();

            IVehicle vehicle = vehicleFactory.CreateVehicle(VehicleType.Car);
            vehicle.Drive();

            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("-----------------------Observer Example--------------------------\n");

            var trafficLight = new TrafficLight();

            trafficLight.DriveUpToLight(new Car());
            trafficLight.DriveUpToLight(new Truck());
            trafficLight.DriveUpToLight(new Motorcycle());
            trafficLight.DriveUpToLight(new Car());
            trafficLight.DriveUpToLight(new Bicycle());

            trafficLight.TurnGreen();

            Console.WriteLine("\n---------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
