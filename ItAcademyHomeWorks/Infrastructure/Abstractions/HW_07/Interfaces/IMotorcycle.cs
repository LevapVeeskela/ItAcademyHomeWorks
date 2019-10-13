namespace Infrastructure.Abstractions.HW_07.Interfaces
{
    public interface IMotorcycle
    {
        string RegistrationNumber { get; }

        string VinNumber { get; }

        ushort FuelQuantity { get; set; }

        ushort MaxSpeed { get; }

        ushort CurrentSpeed { get; set; }

        bool IsStartEngine { get; set; }

        ushort Acceleration { get; }

        int ValueOdometer { get; set; }

        bool StartUp();

        void Run();

        ushort GetCurrentSpeed();

        bool Stop();

        ushort GetFuelQuantity();

        ushort ReplenishFuelQuantity(ushort fuelQuantity);
    }
}