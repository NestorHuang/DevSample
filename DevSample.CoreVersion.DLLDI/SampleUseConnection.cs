using DevSample.CoreVersion.DLLDI.ConfigSetting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DevSample.CoreVersion.DLLDI
{
    public class SampleUseConnection
    {
        private IConfigurationRoot config;
        public SampleUseConnection(IServiceProvider serviceProvider)
        {
            config = serviceProvider.GetRequiredService<ConfigSelector>().GetConfig(); ;
        }

        public void ShowConnection()
        {
            Console.WriteLine(config.GetConnectionString("ReadOnly"));
        }
    }
}
