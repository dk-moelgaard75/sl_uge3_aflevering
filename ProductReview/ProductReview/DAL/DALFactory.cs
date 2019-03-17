using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using ProductReview.Utility;


namespace ProductReview.DAL
{
    public static class DALFactory
    {
        public static IDBParser GetDbParser()
        {
            string key = "connectiontype";
            string setting = AppConfigUtil.GetKey(key); //configuration[key];
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
