using System;
using System.Linq;

namespace nap
{
    public class Flag
    {
        public static void ParamType(string[] args)
        {
            if(!args.Any())
            {
                ErrMsg.FlagErrMsg();
            }
            else if(args.Length == 1 && args[0] != "-help")
            {
                ErrMsg.FlagErrMsg();
            }

        	string flag = args[0];

        	switch(flag)
        	{
        		case "-pl":
                    FlagMethods.Play(args[1]);
        			break;

        		case "-st":
                    FlagMethods.Stop(args[1]);
        			break;

        		case "-help":
        			FlagMethods.Help();
                    break;

        		default:
                    ErrMsg.FlagErrMsg();
                    break;
        	}
        }
    }
}