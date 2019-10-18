using Infrastructure.Abstractions.Services;
using System;
using Common.Constants;

namespace BusinessLogic.Services.HW_08
{
    public class RegistrationBaseService
    {
        private readonly IConfigurationPersonService _cps; 
        private readonly ICheckInService _cis;
        private readonly ISecurityCheckService _scs;
        private readonly IPpassportControlService _pcs;

        public RegistrationBaseService()
        {
            _cps = new ConfigurationPersonService();
            _cis = new CheckInService();
            _scs = new SecurityCheckService();
            _pcs = new PpassportControlService();
        }
        
        public bool RunRegistration()
        {
            return RunCheckIn() && RunSecurityCheck() && RunPpassportControl();
        }

        public bool RunCheckIn()
        {
            return true;
        }

        public bool RunSecurityCheck()
        {
            return true;
        } 

        public bool RunPpassportControl()
        {
            return true;
        }

        public void GetResult()
        {
            var person = _cps.GetInfoPerson();
            if (RunRegistration())
            {
                Console.WriteLine(Constants.RegistrationBaseConstants.PatternTextSuccessFlyInfo, person.Passport, person.CountryDestination);
            }
            Console.WriteLine(Constants.RegistrationBaseConstants.PatternTextRejectRegistrationInfo, person.Passport, person.CountryDestination);
        }
    }
}