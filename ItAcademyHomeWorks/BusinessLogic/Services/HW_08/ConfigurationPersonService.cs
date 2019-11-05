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
            Console.WriteLine(Constants.HomeWorkEight.ConfigurationPerson.TextStageConfigurationPersonInfo);
            Person = CreateNewPerson();
        }

        public PersonModel CreateNewPerson()
        {
            return new PersonModel
            {
                Passport = string.Format(Constants.HomeWorkEight.ConfigurationPerson.PatternTextInitialsAndPassportInfo, WriteOrReadConsoleHelper.GetStringValueFromConsole(Constants.HomeWorkEight.ConfigurationPerson.TextEnterInitialInfo)),
                IsHaveBaggage = WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.HomeWorkEight.ConfigurationPerson.TextConfirmationHaveBaggageInfo),
                WeightBags =
                    (ushort)WriteOrReadConsoleHelper.GetIntValueFromConsole(
                        Constants.HomeWorkEight.ConfigurationPerson.TextWeightBaggageInfo, 40),
                IsHaveCarryon = WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.HomeWorkEight.ConfigurationPerson.TextConfirmationHaveCarryonInfo),
                IsHaveTickets =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.HomeWorkEight.ConfigurationPerson.TextConfirmationHaveTicketsInfo),
                IsHaveProhibitedItems =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.HomeWorkEight.ConfigurationPerson.TextConfirmationHaveProhibitedItemsInfo),
                CountryDestination =
                    WriteOrReadConsoleHelper.GetStringValueFromConsole(
                        Constants.HomeWorkEight.ConfigurationPerson.TextEnterCountryDestinationInfo),
                IsHaveVisa =
                    WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.HomeWorkEight.ConfigurationPerson.TextConfirmationHaveVisaInfo)
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