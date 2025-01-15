using System;

namespace ConstructiveBlocks.Static_Classes
{
    public static class StaticClassTeacher
    {
        public static int Number { get; set; }
        public static void PrintNumber()
        {
            Console.WriteLine($"Number : {Number}");
        }
    }
}