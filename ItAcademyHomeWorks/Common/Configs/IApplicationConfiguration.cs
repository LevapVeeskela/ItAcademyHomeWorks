using System.Collections.Generic;

namespace Common.Configs
{
    public interface IApplicationConfiguration
    {
        string Version { get; }

        string Name { get; }

        IEnumerable<string> AllowedFormats { get; }

        string SwaggerUrlTemplate { get; }
    }
}