using Common.Models;

namespace Infrastructure.Abstractions.Services.HW_08
{
    public interface ICheckInService
    {
        bool CheckTickets(PersonModel person);

        void SetTickets(PersonModel person);

        bool ClaimBaggage(PersonModel person);

    }
}
