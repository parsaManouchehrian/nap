using System;

namespace nap
{
    public class ErrMsg
    {
        public static string FlagErrMsg()
        {
            throw new Exception("Please specify a valid flag and filepath. or pass -help for options B^)");
        }
    }
}