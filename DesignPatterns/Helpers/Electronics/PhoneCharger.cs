using System;

namespace DesignPatterns.Helpers.Electronics
{
    public class PhoneCharger
    {
        public void Charge(NorthAmericanOutlet outlet)
        {
            Console.WriteLine("Plugging in the phone.");
            outlet.ChargeElectronic();
        }
    }
}
