using System;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Console.WriteLine();

            Database database2 = new OracleServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }
}