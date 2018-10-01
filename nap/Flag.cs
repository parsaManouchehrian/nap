using System;

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
                    ErrMsg.FlagErrMsg();
                    break;
        	}
        }
    }
}