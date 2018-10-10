using System;

namespace nap
{
    public class Decode
    {
        public static void CheckExt(string filePath, string ext)
        {
        	switch(ext)
        	{
        		// add more case statements for other file types when the time comes

        		case ".mp3":
        			Mp3Decode(filePath);
        			break;

        		case ".wav":
        			WavDecode(filePath);
        			break;

        		default:
        			// add a conditional to check and see if the appropriate flag was passed to decode a non supported file
        			// as raw binary audio >:)
        			throw new Exception("Please pass a valid file type to decode. or pass -help for options B^)");
        	}	
        }

        private static void Mp3Decode(string filePath)
        {
        	// add mp3 decode logic from reference from external libraries :)
        	Console.WriteLine(filePath);
        }

        private static void WavDecode(string filePath)
        {
        	Console.WriteLine(filePath);
        }

        public static void StopPlayback()
        {
        	// add stop logic from reference from external libraries :)
        	Console.WriteLine("playback is stopped");
        }
    }
}