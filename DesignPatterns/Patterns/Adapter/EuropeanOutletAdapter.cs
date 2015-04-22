using DesignPatterns.Helpers.Electronics;

namespace DesignPatterns.Patterns.Adapter
{
    class EuropeanOutletAdapter : NorthAmericanOutlet
    {
        private readonly EuropeanOutlet _outlet;

        public EuropeanOutletAdapter(EuropeanOutlet outlet)
        {
            _outlet = outlet;
        }

        public override void ChargeElectronic()
        {
            _outlet.ChargeElectronic();
        }
    }
}
