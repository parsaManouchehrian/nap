using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace nap
{
    internal class Config
    {
        public static object ReadConfig()
        {
            string configPath = ConfigCheck();
            string text = System.IO.File.ReadAllText(configPath);
            dynamic deserializedJson = JsonConvert.DeserializeObject(text);
            ConfigData config = new ConfigData { MusicPath = deserializedJson.Music_Path};
            return config.MusicPath;
        }
        private static string ConfigCheck()
        {
            string currentPath = GetCurrentPath();
            string configPath = currentPath + "/nap-config.json";
            Console.WriteLine(configPath);
            bool exists = File.Exists(configPath);
            if (exists)
            {
                Console.WriteLine("Config file found");
                return configPath;
            }
            else
            {
                Console.WriteLine("No config file found");
                configPath = GetMusicPath();
                GenerateConfig(configPath);
                return configPath;
            }
        }

        private static string GetMusicPath()
        {
            Console.WriteLine("Type the full file path to the file you want to play");
            string configPath = Console.ReadLine();
            return configPath;
        }
        private static string GetCurrentPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            return currentPath;
        }
        private static void GenerateConfig(string configPath)
        {
            Console.WriteLine("Generating config file...");
            var data = new List<ConfigData> {new ConfigData() {MusicPath = configPath}};
            string currentPath = GetCurrentPath();
            string fileName = "nap-config.json";
            using (StreamWriter file = File.CreateText(currentPath + '/' + fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, data);
            }
        }
    }
}