using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevSample.CoreVersion.DLLDI.ConfigSetting
{
    public class ConfigSelector
    {
        private IConfigSetting configSetting;

        public ConfigSelector(IConfigSetting _configSetting)
        {
            configSetting = _configSetting;
        }

        public IConfigurationRoot GetConfig()
        {
            return configSetting.GetConfiguration();
        }
    }
}
