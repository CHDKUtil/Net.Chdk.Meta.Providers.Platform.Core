using Net.Chdk.Meta.Model.CameraModel;
using System.Collections.Generic;

namespace Net.Chdk.Meta.Providers.Platform
{
    public interface IPlatformProvider
    {
        IDictionary<string, PlatformData> GetPlatforms(string path);
    }
}
