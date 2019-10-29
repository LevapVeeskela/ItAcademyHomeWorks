using Infrastructure.Abstractions.HW_07.Interfaces;

namespace Infrastructure.Abstractions.HW_07.AbstractClasses
{
    public abstract class MotorcycleAbstract
    {

        private ushort _currentSpeed;

        protected MotorcycleAbstract(string registrationNumber, string vinNumber, ushort maxSpeed, int valueOdometer, ushort acceleration = 40)
        {
            RegistrationNumber = registrationNumber;
            VinNumber = vinNumber;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            ValueOdometer = valueOdometer;
        }

        public virtual ushort CurrentSpeed
        {
            get => _currentSpeed;
            set
            {
                if (value <= MaxSpeed)
                {
                    _currentSpeed = value;
                }
            }
        }

        public string RegistrationNumber { get; }

        public ushort MaxSpeed { get; }

        public bool IsStartEngine { get; set; }
        public ushort Acceleration { get; }

        protected ushort FuelQuantity { get; set; }

        private protected string VinNumber { get; }

        private int ValueOdometer { get; set; }

        protected bool StartUp()
        {
            IsStartEngine = true;
            return IsStartEngine;
        }

        public virtual bool Stop()
        {
            if (CurrentSpeed > 0)
            {
                for (var slowDownSpeed = 30; CurrentSpeed == 0; slowDownSpeed--)
                    CurrentSpeed = (ushort)(CurrentSpeed - slowDownSpeed);
                IsStartEngine = false;
            }

            return IsStartEngine;
        }

        protected virtual void Run()
        {
            if (IsStartEngine)
                for (var seconds = 0; CurrentSpeed <= MaxSpeed; seconds++)
                {
                    CurrentSpeed = (ushort)(seconds * Acceleration);
                }
        }

        protected virtual void Run(ushort desiredSpeed, ushort initSpeed = 0)
        {
            if (IsStartEngine)
                for (var seconds = 0; CurrentSpeed < desiredSpeed && desiredSpeed <= MaxSpeed; seconds++)
                    CurrentSpeed = (ushort)((ushort)(initSpeed * Acceleration) + (ushort)(seconds * Acceleration));
        }

        protected virtual string GetVinNumber()
        {
            return VinNumber;
        }

        protected abstract ushort GetFuelQuantity();

        protected abstract ushort ReplenishFuelQuantity(ushort fuelQuantity);
    }
}