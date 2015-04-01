using System.Collections.Generic;
using DesignPatterns.Helpers.Vehicles;

namespace DesignPatterns.Patterns.Observer
{
    public class TrafficLight
    {
        private readonly IList<IVehicle> _vehiclesAtLight;

        public TrafficLight()
        {
            _vehiclesAtLight = new List<IVehicle>();
        }

        public void DriveUpToLight(IVehicle vehicle)
        {
            _vehiclesAtLight.Add(vehicle);
        }

        public void TurnGreen()
        {
            foreach (var vehicle in _vehiclesAtLight)
            {
                vehicle.AlertGreenLight();
            }
        }
    }
}