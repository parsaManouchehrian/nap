using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace nap
{
    internal class Config
    {
        private string MusicPath { get; set; }
        private Config(string musicPath)
        {
            this.MusicPath = musicPath;
        }
        
        public static string ReadConfig()
        {
            string currentPath = GetCurrentPath();
            string configPath = currentPath + "/nap-config.json";

            // Evaluates whether a config file already exists
            bool configExists = DoesConfigExist(configPath);

            if (configExists)
            {
                // Reads existing config
                try
                {
                    string text = System.IO.File.ReadAllText(configPath);
                    dynamic deserializedJson = JsonConvert.DeserializeObject(text);
                    string configStr = "";
                    configStr += deserializedJson.MusicPath;
                    return configStr;
                }
                catch (UnauthorizedAccessException)
                {
                    throw new UnauthorizedAccessException("Unable to access file.");
                }
            }
            else
            {
                configPath = GetMusicPath();
                // Check if File Path exists
                // Turn configExists into a generic file path validator
                configPath += "/Zweihänder - Höllental - 01 Slay The Chopper.ogg";
                // Console.WriteLine(configPath);
                GenerateConfig(currentPath, configPath);
                return "Config generated";
            }
        }

        private static string GetCurrentPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            return currentPath;
        }

        private static bool DoesConfigExist(string configPath)
        {
            bool exists = File.Exists(configPath);
            if (exists)
            {
                Console.WriteLine("Config file found.");
                exists = true;
            }
            else {
                Console.WriteLine("Config file not found.");
                exists = false;
            }
            return exists;
        }
        
        private static string GetMusicPath()
        {
            Console.WriteLine("Type the full file path to the file you want to play");
            string configPath = Console.ReadLine();
            return configPath;
        }

        private static void GenerateConfig(string currentPath, string configPath)
        {
            Console.WriteLine("Generating config file...");
            Config config = new Config(configPath){MusicPath = configPath};
            string configText = $"{config.MusicPath}";
            string fileName = "nap-config.json";
            string filePath = currentPath + '/' + fileName;
            Dictionary<string, string> configDict = new Dictionary<string, string>();
            configDict.Add("MusicPath", config.MusicPath);
            
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object data directly into file stream
                serializer.Serialize(file, configDict);
            }
        }
    }
}