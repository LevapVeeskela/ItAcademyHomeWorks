using System;
using Common.Constants;
using Common.Helpers;
using Infrastructure.Abstractions.Services.HW_08;

namespace BusinessLogic.Services.HW_08
{
    public class RegistrationBaseService
    {
        private readonly IConfigurationPersonService _cps;
        private readonly ICheckInService _cis;
        private readonly ISecurityCheckService _scs;
        private readonly IPassportControlService _pcs;

        public RegistrationBaseService(IConfigurationPersonService cps, ICheckInService cis, ISecurityCheckService scs, IPassportControlService pcs)
        {
            _cps = cps;
            _cis = cis;
            _scs = scs;
            _pcs = pcs;
        }

        public bool RunRegistration()
        {
            return RunCheckIn() && RunSecurityCheck() && RunPassportControl();
        }

        public bool RunCheckIn()
        {
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            Console.WriteLine(Constants.HomeWorkEight.CheckIn.TextStageCheckInInfo);

            var person = _cps.GetInfoPerson();
            var result = _cis.CheckTickets(person);

            if (person.IsHaveBaggage)
            {
                _cis.ClaimBaggage(person);
            }

            return result;
        }

        public bool RunSecurityCheck()
        {
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            Console.WriteLine(Constants.HomeWorkEight.SecurityCheck.TextStageSecurityCheckInfo);

            var person = _cps.GetInfoPerson();
            var result = _scs.CheckPerson(person);

            if (person.IsHaveCarryon)
            {
                result = result && _scs.CheckCarryon(person);
            }

            return result;
        }

        public bool RunPassportControl()
        {
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            Console.WriteLine(Constants.HomeWorkEight.PassportControl.TextStageSPassportControlInfo);

            var person = _cps.GetInfoPerson();
            var result = _pcs.CheckInBaseData(person);

            if (WriteOrReadConsoleHelper.GetPromptConfirmation(string.Format(Constants.HomeWorkEight.PassportControl.TextConfirmationVisaInfo, person.CountryDestination)))
            {
                if (_pcs.CheckVisa(person))
                {
                    _pcs.SetVisa(person);
                    result = person.IsHaveVisa;
                }
            }

            return result;
        }

        public void GetResult()
        {
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            var person = _cps.GetInfoPerson();

            if (RunRegistration())
            {
                Console.WriteLine(Constants.HomeWorkEight.RegistrationBase.PatternTextSuccessFlyInfo, person.Passport, person.CountryDestination);
                return;
            }

            Console.WriteLine(Constants.HomeWorkEight.RegistrationBase.PatternTextRejectRegistrationInfo, person.Passport, person.CountryDestination);
        }
    }
}