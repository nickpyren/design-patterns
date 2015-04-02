using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Helpers.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public void ShowGreenLight()
        {
            Drive();
        }

        public abstract void Drive();
    }
}
