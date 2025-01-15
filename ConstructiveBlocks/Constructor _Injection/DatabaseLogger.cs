using System;

namespace ConstructiveBlocks.Constructive_Injection
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }
}