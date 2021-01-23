using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace AutomationFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            
            IConfigurationRoot config = builder.Build();
            Settings.AUT = config.GetSection("testsettings").Get<TestSettings>().AUT;
            Settings.Browser = config.GetSection("testsettings").Get<TestSettings>().Browser;
        }
    }
}
