using Newtonsoft.Json;
using System;
using System.IO;

namespace TestStackWhiteFramework.Utils
{
    public static class MyUtil
    {
        private static readonly string pathToTheConfigFile = AppDomain.CurrentDomain.BaseDirectory + @"/Resources/configuration.json";
        public static ConfigurationData GetValueFromConfig()
        {
            var json = new ConfigurationData
            {
                Path = "",
                WindowName = "",
                ImageName = "",
                CopyImageName = "",
                ModalWindowName = ""
            };
            var strJson = File.ReadAllText(pathToTheConfigFile);
            json = JsonConvert.DeserializeObject<ConfigurationData>(strJson);
            return json;
        }
    }
}
