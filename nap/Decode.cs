using System;

namespace nap
{
    public class Decode
    {
        public static void Decode(string filePath, string ext)
        {
        	switch(ext)
        	{
        		// add more case statements for other file types when the time comes
        		
        		case ".mp3":
        			Mp3Decode(filePath);

        		case ".wav":
        			WavDecode(filePath);

        		default:
        			// add a conditional to check and see if the appropriate flag was passed to decode a non supported file
        			// as raw binary audio >:)
        			throw new Exception("Please pass a valid file type to decode. or pass -help for options B^)");
        	}	
        }

        private static void Mp3Decode(string filePath)
        {
        	Console.WriteLine(filePath);
        }

        private static void WavDecode(string filePath)
        {
        	Console.WriteLine(filePath);
        }
    }
}