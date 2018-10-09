using System;

namespace nap
{
    public class FlagMethods
    {
        public static void Play(string filePath)
        {
            Console.WriteLine(filePath);
        }

        public static void Stop()
        {
            Console.WriteLine("called stop method");
        }

        public static void Help()
        {
        	Console.WriteLine("help info goes here");
        }
    }
}