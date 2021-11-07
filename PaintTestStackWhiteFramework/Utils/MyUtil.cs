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
        public static void CopyFiles(string sourceDir, string backupDir, string pictureName)
        {
            try
            {
                string[] picList = Directory.GetFiles(sourceDir, "*.jpg");
                foreach (string f in picList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);
                    File.Copy(Path.Combine(sourceDir, pictureName), Path.Combine(backupDir, MyUtil.GetValueFromConfig().CopyImageName.ToString()), true);
                }
            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }
    }
}
