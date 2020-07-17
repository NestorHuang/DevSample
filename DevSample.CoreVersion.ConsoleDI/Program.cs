using DevSample.CoreVersion.DAL;
using DevSample.CoreVersion.DLLDI;
using DevSample.CoreVersion.DLLDI.ConfigSetting;
using DevSample.CoreVersion.DLLDI.Hello;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DevSample.CoreVersion.ConsoleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.建立依賴注入的容器
            var serviceCollection = new ServiceCollection();
            // 2. 註冊服務
            serviceCollection.AddTransient<HelloSelector>();            
            serviceCollection.AddTransient<IHello, EngHello>();
            //serviceCollection.AddTransient<ConfigureServices>();

            serviceCollection.AddSingleton<ConfigSelector>();
            serviceCollection.AddSingleton<IConfigSetting, ConsoleSetting>();
            // 建立依賴服務提供者
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // 3. 執行主服務
            serviceProvider.GetRequiredService<HelloSelector>().Say();

            var _configSelect = serviceProvider.GetRequiredService<ConfigSelector>();
            var _config = _configSelect.GetConfig();
            //Console.WriteLine(_config.GetSection("TestSetting").Value);
            //Console.WriteLine(_config.GetSection("Settings").GetSection("Set1").Value);
            //Console.WriteLine(_config.GetSection("Settings:Set2").Value);
            EInvoice.UpdateXMLExported(_config.GetConnectionString("ReadWrite"));
            //Console.WriteLine(_config.GetConnectionString("ReadWrite"));

            //new SampleUseConnection(serviceProvider).ShowConnection(); 
        }
    }
}
