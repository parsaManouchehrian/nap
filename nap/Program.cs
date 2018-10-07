using System;

namespace nap
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string filePath = Flag.ParamType(args);
            string configStr = Config.ReadConfig(filePath);   
            Console.WriteLine($"Main Method: {configStr}");
        }

        public static string Test()
        {
            return "Hello World!";
        }
    }
}
