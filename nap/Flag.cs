using System;

namespace nap
{
    public class Flag
    {
        public static void ParamType(string[] args)
        {
        	string flag = args[0];
            string filePath = args[1];

        	switch(flag)
        	{
        		case "-pl":
                    FlagMethods.Play(filePath);
        			break;

        		case "-st":
                    FlagMethods.Stop(filePath);
        			break;

        		case "-help":
        			FlagMethods.Help();
                    break;
                    
        		default:
        			throw new Exception("Please Specify a valid Flag. or pass -help for options");
        	}
        }
    }
}