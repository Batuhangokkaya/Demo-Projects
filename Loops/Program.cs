using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop
            ForLoop forLoop = new ForLoop();
            forLoop.ForMethod1();
            forLoop.ForMethod2();
            forLoop.ForMethod3();
            forLoop.ForMethod4();

            Console.WriteLine();

            // While Loop
            WhileLoop whileLoop = new WhileLoop();
            whileLoop.WhileLoop1();
            whileLoop.WhileLoop2();

            Console.WriteLine();

            // Do While Loop
            DoWhileLoop doWhileLoop = new DoWhileLoop();
            doWhileLoop.DoWhileLoop1();
            doWhileLoop.DoWhileLoop2();
            doWhileLoop.DoWhileLoop3();
            doWhileLoop.DoWhileLoop4();
            
            Console.WriteLine();

            // Foreach Loop
            ForeachLoop foreachLoop = new ForeachLoop();
            foreachLoop.ForeachLoop1();

            // ReCap Prime Number
            ReCapPrimeNumber reCapPrimeNumber = new ReCapPrimeNumber();
            if (reCapPrimeNumber.IsPrimeNumber(8))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }
            Console.ReadLine();
        }
    }
}