using System;
using Common.Constants;
using Common.Models;
using Infrastructure.Abstractions.Services.HW_08;

namespace BusinessLogic.Services.HW_08
{
    public class SecurityCheckService : ISecurityCheckService
    {
        public bool CheckCarryon(PersonModel person)
        {
            if (person.IsHaveCarryon)
            {
                Console.WriteLine(Constants.SecurityCheck.TextCheckCarryonInfo);
                return !person.IsHaveProhibitedItems;
            }

            return true;
        }

        public bool CheckPerson(PersonModel person)
        {
            if (person.IsHaveCarryon)
            {
                Console.WriteLine(Constants.SecurityCheck.TextCheckPersonInfo);
                return !person.IsHaveProhibitedItems;
            }

            return true;
        }
    }
}
