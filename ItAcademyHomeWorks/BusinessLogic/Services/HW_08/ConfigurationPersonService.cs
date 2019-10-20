using System;
using Common.Constants;
using Common.Helpers;
using Common.Models;

using Infrastructure.Abstractions.Services.HW_08;

namespace BusinessLogic.Services.HW_08
{
    public class ConfigurationPersonService : IConfigurationPersonService
    {
        private PersonModel Person { get; }

        public ConfigurationPersonService()
        {   
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            Console.WriteLine(Constants.ConfigurationPerson.TextStageConfigurationPersonInfo);
            Person = CreateNewPerson();
        }

        public PersonModel CreateNewPerson()
        {
            return new PersonModel
            {
                Passport = string.Format(Constants.ConfigurationPerson.PatternTextInitialsAndPassportInfo, WriteOrReadConsoleHelper.GetStringValueFromConsole(Constants.ConfigurationPerson.TextEnterInitialInfo)),
                IsHaveBaggage = WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPerson.TextConfirmationHaveBaggageInfo),
                WeightBags =
                    (ushort)WriteOrReadConsoleHelper.GetIntValueFromConsole(
                        Constants.ConfigurationPerson.TextWeightBaggageInfo, 40),
                IsHaveCarryon = WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPerson.TextConfirmationHaveCarryonInfo),
                IsHaveTickets =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPerson.TextConfirmationHaveTicketsInfo),
                IsHaveProhibitedItems =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPerson.TextConfirmationHaveProhibitedItemsInfo),
                CountryDestination =
                    WriteOrReadConsoleHelper.GetStringValueFromConsole(
                        Constants.ConfigurationPerson.TextEnterCountryDestinationInfo),
                IsHaveVisa =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.ConfigurationPerson.TextConfirmationHaveVisaInfo)
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