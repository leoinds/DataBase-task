using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStackWhiteFramework
{
    public static class ConfigurationData
    {
        public static readonly string json = Environment.CurrentDirectory + @"/Resources/configuration.json";
        public static readonly string name = json[path];
        public static readonly string windowName = Environment.CurrentDirectory + @"/Resources/configuration.json/windowName";
    }
}
