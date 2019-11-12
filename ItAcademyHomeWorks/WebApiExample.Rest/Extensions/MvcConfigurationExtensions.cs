using Common.Configs;
using Common.Configs.Implementations;
using Microsoft.Extensions.Configuration;
using WebApiExample.Rest.Constants;

namespace WebApiExample.Rest.Extensions
{
    public static class MvcConfigurationExtensions
    {
        public static IApplicationConfiguration GetApplicationConfiguration(this IConfiguration configuration)
            => configuration.GetConfiguration<IApplicationConfiguration, ApplicationConfiguration>(ConfigurationSectionNames.Application);

        public static TConfiguration GetConfiguration<TConfiguration, TConfigurationImplementation>(
            this IConfiguration configuration,
            string sectionName) where TConfigurationImplementation : TConfiguration
        {
            var s = configuration
                .GetSection(sectionName);
            var t = s.Get<TConfigurationImplementation>();
            return t;
        }
            //=> configuration
            //    .GetSection(sectionName)
            //    .Get<TConfigurationImplementation>();
    }
}