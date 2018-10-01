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
            bool configExists = DoesFileExist(configPath);

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
                bool fileExists = DoesFileExist(configPath);
                while (!fileExists)
                {
                    configPath = GetMusicPath();
                    fileExists = DoesFileExist(configPath);
                }
                
                // Hard coded song name. Needs fixing.
                configPath += "/Zweihänder - Höllental - 01 Slay The Chopper.ogg";
                GenerateConfig(currentPath, configPath);
                return "Config generated";
            }
        }

        private static string GetCurrentPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            return currentPath;
        }

        // Generic Method to check if a file exists
        private static bool DoesFileExist(string filePath)
        {
            bool exists = File.Exists(filePath);
            if (exists)
            {
                exists = true;
            }
            else {
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