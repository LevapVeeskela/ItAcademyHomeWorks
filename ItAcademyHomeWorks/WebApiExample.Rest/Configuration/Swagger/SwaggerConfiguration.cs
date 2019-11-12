using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using WebApiExample.Rest.Extensions;

namespace WebApiExample.Rest.Configuration.Swagger
{
    /// <summary>
    /// Кинфигурация свагера
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Метод расширения для конфигурации свагера
        /// </summary>
        /// <param name="app"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IApplicationBuilder ConfigureSwagger(this IApplicationBuilder app, IConfiguration configuration)
        {
            var appCfg = configuration.GetApplicationConfiguration();
            var url = string.Format(appCfg.SwaggerUrlTemplate, appCfg.Version);

            app.UseSwagger();
            app.UseSwaggerUI(_ => _.SwaggerEndpoint(url, appCfg.Name));

            return app;
        }
    }
}