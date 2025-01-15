using System;

namespace ConstructiveBlocks.Constructive_Injection
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
}