using System;

namespace DevSample.NUnit.Chapter2
{
    public class LogAnalyzer
    {
        public bool InValidLogFileName(string fileName)
        {
            if (!fileName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}
