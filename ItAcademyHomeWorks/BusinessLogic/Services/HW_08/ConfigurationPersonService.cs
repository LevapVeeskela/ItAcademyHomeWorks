using Common.Constants;
using Common.Helpers;
using Common.Models;
using Infrastructure.Abstractions.Services;

namespace BusinessLogic.Services.HW_08
{
    internal class ConfigurationPersonService : IConfigurationPersonService
    {
        private PersonModel Person { get; }
        internal ConfigurationPersonService()
        {
            Person = CreateNewPerson();
        }

        public PersonModel CreateNewPerson()
        {
            return new PersonModel
            {
                Passport = string.Format(ConfigurationPersonConstants.PatternTextInitialsAndPassportInfo, WriteOrReadConsoleHelper.GetStringValueFromConsole(ConfigurationPersonConstants.TextEnterInitialInfo)),
                IsHaveBaggage = WriteOrReadConsoleHelper.GetPromptConfirmation(ConfigurationPersonConstants.TextConfirmationHaveBaggageInfo),
                WeightBags =
                    (ushort)WriteOrReadConsoleHelper.GetIntValueFromConsole(
                        ConfigurationPersonConstants.TextWeightBaggageInfo, 40),
                IsHaveTickets =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(ConfigurationPersonConstants.TextConfirmationHaveTicketsInfo),
                CountryDestination =
                    WriteOrReadConsoleHelper.GetStringValueFromConsole(
                        ConfigurationPersonConstants.TextEnterCountryDestinationInfo),
                IsHaveVisa =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(ConfigurationPersonConstants.TextConfirmationHaveVisaInfo)
            };
        }

        public PersonModel GetInfoPerson()
        {
            return Person;
        }

        public PersonModel SetVisaOrTempVisa()
        {
            Person.IsHaveVisa = true;
            return Person;
        }
    }
}