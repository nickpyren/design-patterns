using System;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Factory Example--------------------------\n");

            var vehicleFactory = new VehicleFactory();

            IVehicle vehicle = vehicleFactory.GetVehicle(VehicleType.Car);
            Console.WriteLine(vehicle.Drive());

            Console.WriteLine("\n---------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
