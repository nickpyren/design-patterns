
using System;

namespace DesignPatterns.Helpers.Vehicles
{
    class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Ding ding! I'm a bicycle!");
        }
    }
}
