using Infrastructure.Abstractions.HW_07.Interfaces;

namespace AssemblyOne
{
    /// <summary>
    /// Default access modifier Internal 
    /// </summary>
    sealed class MotorcycleDefaultInternal : IMotorcycle
    {
        public string RegistrationNumber { get; }
        public string VinNumber { get; }
        public ushort FuelQuantity { get; set; }
        public ushort MaxSpeed { get; }
        public ushort CurrentSpeed { get; set; }
        public bool IsStartEngine { get; set; }
        public ushort Acceleration { get; }
        public int ValueOdometer { get; set; }

        public MotorcycleDefaultInternal(string registrationNumber, string vinNumber, ushort maxSpeed, int valueOdometer = 0, ushort acceleration = 40)
        {
            RegistrationNumber = registrationNumber;
            VinNumber = vinNumber;
            MaxSpeed = maxSpeed;
            ValueOdometer = valueOdometer;
            Acceleration = acceleration;
        }
        public bool StartUp()
        {
            IsStartEngine = true;
            return IsStartEngine;
        }

        public void Run()
        {
            if (IsStartEngine)
                for (var seconds = 0; CurrentSpeed <= MaxSpeed; seconds++)
                {
                    CurrentSpeed = (ushort)(seconds * Acceleration);
                }
        }

        public ushort GetCurrentSpeed()
        {
            return CurrentSpeed;
        }

        public bool Stop()
        {
            if (CurrentSpeed > 0)
            {
                for (var seconds = 0; CurrentSpeed == 0; seconds++)
                    CurrentSpeed = (ushort)(seconds * Acceleration);
            }

            return IsStartEngine;
        }
        public ushort GetFuelQuantity()
        {
            return FuelQuantity;
        }

        public ushort ReplenishFuelQuantity(ushort fuelQuantity)
        {
            FuelQuantity = (ushort)(FuelQuantity + fuelQuantity);
            return FuelQuantity;
        }
    }
}