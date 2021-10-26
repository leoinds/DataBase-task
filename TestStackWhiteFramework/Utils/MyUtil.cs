using Newtonsoft.Json;
using System;
using System.IO;

namespace TestStackWhiteFramework.Utils
{
    public static class MyUtil
    {
        private static readonly string pathToTheConfigFile = AppDomain.CurrentDomain.BaseDirectory + @"/Resources/configuration.json";
        //я прописал путь calc1.exe, но на своем компе я прописывал в JSON абсолютный путь к калькулятору 7 винды
        //"C:\\Users\\l.ermakovich\\source\\repos\\TestStackWhiteFramework\\bin\\Debug\\Resources\\calc.exe"


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

            //не сработало: Environment.CurrentDirectory + @"/Resources/configuration.json"
            var strJson = File.ReadAllText(pathToTheConfigFile);
            json = JsonConvert.DeserializeObject<ConfigurationData>(strJson);
            return json.WindowName;
        }
    }
}
