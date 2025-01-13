using System;

namespace AbstractClasses
{
    public class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer!");
        }
    }
}
