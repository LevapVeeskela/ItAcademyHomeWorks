using System;
using Common.Constants;
using Common.Models;
using Infrastructure.Abstractions.Services.HW_08;

namespace BusinessLogic.Services.HW_08
{
    public class PassportControlService : IPassportControlService
    {
        public bool CheckInBaseData(PersonModel person)
        {
            Console.WriteLine(Constants.HomeWorkEight.PassportControl.TextImitationCheckPassportInBdInfo);
            return !string.IsNullOrWhiteSpace(person.Passport);
        }

        public bool CheckVisa(PersonModel person)
        {
            return person.IsHaveVisa;
        }

        public void SetVisa(PersonModel person)
        {
            person.IsHaveVisa = true;
        }
    }
}
