using System;

namespace nap
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            Flag.ParamType(args);

            object configObj = Config.ReadConfig();
            string configStr = "";
            configStr += configObj;
        }

        public static string Test()
        {
            return "Hello World!";
        }
    }
}
