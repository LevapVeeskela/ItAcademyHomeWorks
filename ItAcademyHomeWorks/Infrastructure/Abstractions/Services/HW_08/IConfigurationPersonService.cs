using Common.Models;

namespace Infrastructure.Abstractions.Services
{
    public interface IConfigurationPersonService
    {
        PersonModel CreateNewPerson();

        PersonModel GetInfoPerson();

        PersonModel SetVisaOrTempVisa();
    }
}