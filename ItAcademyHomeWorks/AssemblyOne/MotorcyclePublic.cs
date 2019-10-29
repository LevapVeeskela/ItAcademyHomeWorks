using Infrastructure.Abstractions.HW_07.AbstractClasses;

namespace AssemblyOne
{
    /// <summary>
    /// Available from any assembly, because access modifier public
    /// </summary>
    public sealed class MotorcyclePublic: MotorcycleAbstract
    {
        const ushort TankMalfunction = 1;

        public MotorcyclePublic(string registrationNumber, string vinNumber, ushort maxSpeed, ushort acceleration, int valueOdometer) : base(registrationNumber, vinNumber, maxSpeed, valueOdometer)
        {
        }

        protected override ushort GetFuelQuantity()
        {
            return FuelQuantity;
        }

        protected override ushort ReplenishFuelQuantity(ushort fuelQuantity)
        {
            FuelQuantity = (ushort)(FuelQuantity + fuelQuantity - TankMalfunction);
            return FuelQuantity;
        }
    }
}