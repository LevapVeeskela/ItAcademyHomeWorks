using System.Collections.Generic;

namespace Common.Configs.Implementations
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public string Version { get; }

        public string Name { get; }

        public IEnumerable<string> AllowedFormats { get; }

        public string SwaggerUrlTemplate { get; }
    }
}