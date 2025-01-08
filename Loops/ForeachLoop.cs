using System;

namespace Loops
{
    internal class ForeachLoop
    {
        public void ForeachLoop1()
        {
            string[] Names = new string[] { "Cüneyt", "Asuman", "Batuhan", "Burak", "Yasemin" };
            foreach (var Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }
}