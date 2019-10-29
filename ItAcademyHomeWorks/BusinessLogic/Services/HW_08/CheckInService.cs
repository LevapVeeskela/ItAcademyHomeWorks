using System;
using Common.Constants;
using Common.Helpers;
using Common.Models;
using Infrastructure.Abstractions.Services.HW_08;

namespace BusinessLogic.Services.HW_08
{
    public class CheckInService : ICheckInService
    {
        public bool CheckTickets(PersonModel person)
        {
            var isHaveTickets = WriteOrReadConsoleHelper.GetPromptConfirmation(string.Format(Constants.CheckIn.PatternTextWelcomeInfo, DateTime.Now.ToString(Constants.CheckIn.FormatDate), person.CountryDestination));

            if (!isHaveTickets)
            {
                Console.WriteLine(Constants.CheckIn.TextGetPassportInfo);
                SetTickets(person);
                return person.IsHaveTickets;
            }

            Console.WriteLine(Constants.CheckIn.TextGetPassportAndTicketInfo);

            return person.IsHaveTickets;
        }

        public void SetTickets(PersonModel person)
        {
            person.IsHaveTickets = true;
        }

        public bool ClaimBaggage(PersonModel person)
        {
            if (person.WeightBags > Constants.CheckIn.ValueLimitWeightBaggage)
            {
                Console.WriteLine(Constants.CheckIn.TextDutyBaggageInfo);
            }
            return person.IsHaveBaggage;
        }
    }
}