using System;

namespace DesignPatterns.Helpers.Electronics
{
    public class NorthAmericanOutlet
    {
        public virtual void ChargeElectronic()
        {
            Console.WriteLine("Recharging!");
        }
    }
}