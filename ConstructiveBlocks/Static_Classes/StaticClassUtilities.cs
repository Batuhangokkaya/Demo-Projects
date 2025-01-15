using System;

namespace ConstructiveBlocks.Static_Classes
{
    public static class StaticClassUtilities
    {
        public static string Utilities { get; set; }
        static StaticClassUtilities()
        {
            Utilities = "Javascripts";
        }

        public static void PrintInformation()
        {
            Console.WriteLine($"Utilities : {Utilities}");
        }
    }
}