using Infrastructure.Abstractions.HW_07.AbstractClasses;

namespace AssemblyOne
{
    /// <summary>
    /// Explicit indication access modifier Internal 
    /// </summary>
    internal class MotorcycleInternal : MotorcycleAbstract
    {
        readonly ushort _weight; // default private 
        private readonly ushort _weightOwner; // default private 
        private protected ushort TotalWeight { get; set; }

        public MotorcycleInternal(string registrationNumber, string vinNumber, ushort maxSpeed, ushort acceleration, int valueOdometer, ushort weight, ushort weightOwner) : base(registrationNumber, vinNumber, maxSpeed, valueOdometer, acceleration)
        {
            _weight = weight;
            _weightOwner = weightOwner;
            TotalWeight = (ushort) (_weight + _weightOwner);
        }

        public override bool Stop()
        {
            IsStartEngine = false;
            return IsStartEngine;
        }

        protected override ushort GetFuelQuantity()
        {
            return FuelQuantity;
        }

        protected override ushort ReplenishFuelQuantity(ushort fuelQuantity)
        {
            FuelQuantity = (ushort)(FuelQuantity + fuelQuantity);
            return FuelQuantity;
        }
    }
}