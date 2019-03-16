using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ProductReview.DAL
{
    public static class DALFactory
    {
        public static IDBParser GetDbParser()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            // Duplicate here any configuration sources you use.
            //configurationBuilder.AddJsonFile("AppSettings.json");
            configurationBuilder.AddXmlFile("config.xml");
            IConfiguration configuration = configurationBuilder.Build();
            string key = "connectiontype";
            string setting = configuration[key];
            IDBParser obj;
            if (setting == "mssql")
            {
                obj = new MsSqlServer();
            }
            else if (setting == "postgres")
            {
                obj = new Postgres();
            }
            else
            {
                obj = null;
            }
            return obj;
        }
    }
}
