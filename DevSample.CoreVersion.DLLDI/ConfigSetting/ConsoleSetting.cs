using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace DevSample.CoreVersion.DLLDI.ConfigSetting
{
    public class ConsoleSetting : IConfigSetting
    {
        IConfigurationRoot configuration;

        public ConsoleSetting()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
        }

        public IConfigurationRoot GetConfiguration()
        {
            return configuration;
        }
    }
}
