using System;

namespace nap
{
    public class Flag
    {
        public static void ParamType(string[] args)
        {
			if (args.Length == 0)
			{
				Console.WriteLine("Please pass in flags for the program to use.");
				Console.WriteLine("Use the -help flag for a list of possible flags.");

				throw new IndexOutOfRangeException("The number of arguments should be greater than 0.");
			}
			
        	string flag = args[0];

        	switch(flag)
        	{
        		case "-pl":
        			Console.WriteLine("call play and pass file argument");
        			break;
        		case "-st":
        			Console.WriteLine("call stop and pass file argument");
        			break;
        		case "-help":
        			Console.WriteLine("eventually list all the help options");
        			break;
        		default:
        			throw new Exception("Please Specify a valid Flag. or pass -help for options");
        	}
        }
    }
}