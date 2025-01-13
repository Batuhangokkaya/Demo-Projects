using System;

namespace AbstractClasses
{
    public class OracleServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by OracleServer!");
        }
    }
}