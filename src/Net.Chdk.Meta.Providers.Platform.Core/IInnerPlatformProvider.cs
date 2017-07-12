using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.Platform
{
    public interface IInnerPlatformProvider
    {
        IEnumerable<KeyValuePair<string, string>> DoGetPlatforms(TextReader reader);
        string Extension { get; }
    }
}
