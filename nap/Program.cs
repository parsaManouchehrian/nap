using System;
using System.Linq;

namespace nap
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Flag.ParamType(args);
            string configStr = Config.ReadConfig(args.Last());
            Console.WriteLine($"Main Method: {configStr}");
        }
    }
}
