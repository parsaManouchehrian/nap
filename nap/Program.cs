using System;

namespace nap
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string configStr = Config.ReadConfig();   
            Console.WriteLine($"Main Method: {configStr}");
            Flag.ParamType(args);
        }

        public static string Test()
        {
            return "Hello World!";
        }
    }
}
