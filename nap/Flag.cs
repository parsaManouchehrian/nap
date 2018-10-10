using System;
using System.Linq;

namespace nap
{
    public class Flag
    {
        public static void ParamType(string[] args)
        {
            if(!args.Any() || args.Length == 1 && args[0] != "-help")
            {
                FlagErrMsg();
            }

            // Change to handle multiple flags
        	string flag = args[0];

        	switch(flag)
        	{
        		case "-pl":
                    FlagMethods.Play(args.Last());
        			break;

        		case "-st":
                    FlagMethods.Stop();
        			break;

        		case "-help":
        			FlagMethods.Help();
                    break;

        		default:
                    FlagErrMsg();
                    break;
        	}
        }

        private static string FlagErrMsg()
        {
            throw new Exception("Please specify a valid flag and filepath. or pass -help for options B^)");
        }
    }
}