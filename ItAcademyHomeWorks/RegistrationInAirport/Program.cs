using System;
using BusinessLogic.Services.HW_08;

namespace RegistrationInAirport
{
    class RegistrationInAirport
    {
        static void Main(string[] args)
        {
            RunRegistration();
        }

        static void RunRegistration()
        {
            var rbs = new RegistrationBaseService(new ConfigurationPersonService(),new CheckInService(), new SecurityCheckService(), new PassportControlService());
            rbs.GetResult();
            Console.ReadKey();
        }
    }
}
