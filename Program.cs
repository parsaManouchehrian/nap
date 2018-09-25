using System;

namespace nap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* db:
            * I'll clean this up a bit more
            * Shouldn't have this much going on in the main function
            */

            object configObj = Config.ReadConfig();
            string configStr = "";
            configStr += configObj;
            string mp3Path = configStr + "/sample.mp3";
            Console.WriteLine(mp3Path);
        }
    }
}
