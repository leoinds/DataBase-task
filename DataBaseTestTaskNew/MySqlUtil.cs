using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTestTaskNew
{
    public static class MySqlUtil
    {
        public static MySqlConnectionStringBuilder GetBuilder()
        {
            DBConfiguration dbConfig = JsonConvert.DeserializeObject<DBConfiguration>(File.ReadAllText(@"C:\Users\l.ermakovich\source\repos\DataBaseTestTaskNew\Resources\configuration.json"));
            var builder = new MySqlConnectionStringBuilder
            {
                Server = dbConfig.Server,
                Database = dbConfig.Database,
                UserID = dbConfig.UserID,
                Password = dbConfig.Password
            };
            return builder;
        }
    }
}
