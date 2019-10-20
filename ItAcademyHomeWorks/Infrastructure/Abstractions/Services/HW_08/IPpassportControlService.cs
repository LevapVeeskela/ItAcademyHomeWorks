using Common.Models;

namespace Infrastructure.Abstractions.Services.HW_08
{
    public interface IPassportControlService
    {
        bool CheckInBaseData(PersonModel person);

        bool CheckVisa(PersonModel person);

        void SetVisa(PersonModel person);
    }
}
