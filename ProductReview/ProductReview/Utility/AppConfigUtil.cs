using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ProductReview.Utility
{
    public static class AppConfigUtil
    {
        private static IConfiguration _config = null;
        private static IConfiguration GetConfig
        {
            get
            {
                if (_config == null)
                {
                    IConfigurationBuilder configBuilder = new ConfigurationBuilder();
                    configBuilder.AddXmlFile("config.xml");
                    _config = configBuilder.Build();
                }
                return _config;
            }
        }

        public static string GetKey(string key)
        {
            return GetConfig[key];
        }
    }
}
