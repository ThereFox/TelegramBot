
using Newtonsoft.Json;
using System.Reflection;

namespace ConsoleApp2.Models
{
    public static class Config
    {
        private static Settings _settings;
        
        public static Settings getSettings()
        {
            if (_settings == null)
            {
                //var path = Assembly.GetExecutingAssembly().Location + "/config.json";
                var path = @"F:\C# learn\.net system\CLR iva C#\ConsoleApp2\config.json";

                if (File.Exists(path) == false)
                {
                    throw new Exception("Файл конфигурации потерян");
                }

                var data = new StreamReader(path).ReadToEnd();

                _settings = JsonConvert.DeserializeObject<Settings>(data);
            }
            return _settings;
        }
    }
}
