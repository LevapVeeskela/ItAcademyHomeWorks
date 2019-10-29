using Common.Models;

namespace Infrastructure.Abstractions.Services.HW_08
{
    public interface IConfigurationPersonService
    {
        PersonModel CreateNewPerson();

        PersonModel GetInfoPerson();

        PersonModel SetVisaOrTempVisa();
    }
}