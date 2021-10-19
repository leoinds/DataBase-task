using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DataBaseTestTaskNew
{
    public static class MySqlUtil
    {
        private static readonly string pathToTheConfigFile = Environment.CurrentDirectory + @"/Resources/configuration.json";
        public static MySqlConnectionStringBuilder GetBuilder()
        {
            DBConfiguration dbConfig = JsonConvert.DeserializeObject<DBConfiguration>(File.ReadAllText(pathToTheConfigFile));
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
