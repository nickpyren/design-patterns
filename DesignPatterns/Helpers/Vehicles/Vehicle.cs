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
