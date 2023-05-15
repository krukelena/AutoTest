using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configuration
{
    public static class Configuration
    {
        public static BrowserConfiguration Browser = new BrowserConfiguration();

        public static string CurrentDirectory => Directory.GetCurrentDirectory();

        private static T BindConfiguration<T>(IConfigurationRoot configurationRoot = null!) where T : IConfiguration
        {
            var config = Activator.CreateInstance<T>();
            (configurationRoot ?? ConfigurationRoot).GetSection(config.SectionName).Bind(config);
            return config;
        }
        public static IConfigurationRoot ConfigurationRoot =>

             new ConfigurationBuilder()
            .SetBasePath(CurrentDirectory)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile("appsettings.custom.json", true, true)
                .Build();
    }
}
