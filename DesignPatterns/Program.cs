using System;
using DesignPatterns.Helpers.Electronics;
using DesignPatterns.Helpers.Vehicles;
using DesignPatterns.Patterns.Adapter;
using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Observer;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
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

            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("-----------------------Adapter Example--------------------------\n");

            var phoneCharger = new PhoneCharger();
            var europeanOutlet = new EuropeanOutlet();

            phoneCharger.Charge(new EuropeanOutletAdapter(europeanOutlet));

            Console.WriteLine("\n---------------------------------------------------------------");


            Console.ReadKey();
        }
    }
}
