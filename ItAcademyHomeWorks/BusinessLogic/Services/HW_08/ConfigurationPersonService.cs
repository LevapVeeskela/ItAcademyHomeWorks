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
                Passport = string.Format(Constants.ConfigurationPersonConstants.PatternTextInitialsAndPassportInfo, WriteOrReadConsoleHelper.GetStringValueFromConsole(Constants.ConfigurationPersonConstants.TextEnterInitialInfo)),
                IsHaveBaggage = WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPersonConstants.TextConfirmationHaveBaggageInfo),
                WeightBags =
                    (ushort)WriteOrReadConsoleHelper.GetIntValueFromConsole(
                        Constants.ConfigurationPersonConstants.TextWeightBaggageInfo, 40),
                IsHaveTickets =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPersonConstants.TextConfirmationHaveTicketsInfo),
                CountryDestination =
                    WriteOrReadConsoleHelper.GetStringValueFromConsole(
                        Constants.ConfigurationPersonConstants.TextEnterCountryDestinationInfo),
                IsHaveVisa =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPersonConstants.TextConfirmationHaveVisaInfo)
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