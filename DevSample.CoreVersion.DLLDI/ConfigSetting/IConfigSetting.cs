using Microsoft.Extensions.Configuration;

namespace DevSample.CoreVersion.DLLDI.ConfigSetting
{
    public interface IConfigSetting
    {
        public IConfigurationRoot GetConfiguration();
    }
}
