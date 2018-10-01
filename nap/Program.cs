using System;

namespace nap
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string configStr = Config.ReadConfig();   
            Console.WriteLine($"Main Method: {configStr}");
        }
        public static string Test()
        {
            return "Hello World!";
        }
    }
}
