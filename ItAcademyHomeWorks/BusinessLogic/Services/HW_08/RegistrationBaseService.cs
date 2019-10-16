namespace BusinessLogic.Services.HW_08
{
    public class RegistrationBaseService
    {
        private ConfigurationPersonService _cps; 
        public RegistrationBaseService()
        {
            _cps = new ConfigurationPersonService();
        }
    }
}