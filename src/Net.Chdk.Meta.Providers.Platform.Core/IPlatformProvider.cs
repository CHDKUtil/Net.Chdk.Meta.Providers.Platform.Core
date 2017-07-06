using Net.Chdk.Meta.Model.CameraModel;
using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.Platform
{
    public interface IPlatformProvider
    {
        IDictionary<string, PlatformData> GetPlatforms(Stream stream);
    }
}
