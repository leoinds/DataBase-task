using Newtonsoft.Json;
using System;
using System.IO;

namespace TestStackWhiteFramework.Utils
{
    public static class MyUtil
    {
        private static readonly string pathToTheConfigFile = Environment.CurrentDirectory + @"/Resources/configuration.json";

        public static string GetPath()
        {
            var json = new ConfigurationData
            {
                Path = "",
                WindowName = ""
            };

            var strJson = File.ReadAllText(pathToTheConfigFile);
            json = JsonConvert.DeserializeObject<ConfigurationData>(strJson);
            return json.Path;
        }
        public static string GetWindowName()
        {
            var json = new ConfigurationData
            {
                Path = "",
                WindowName = ""
            };

            //var strJson = File.ReadAllText(@"C:\Users\l.ermakovich\source\repos\TestStackWhiteFramework\bin\Debug\Resources\configuration.json");
            var strJson = File.ReadAllText(pathToTheConfigFile);
            json = JsonConvert.DeserializeObject<ConfigurationData>(strJson);
            return json.WindowName;

        }
    }
}
