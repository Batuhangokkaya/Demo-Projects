using System;

namespace ErrorManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exception Handling.
            Console.WriteLine("--Exception Handling--");
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            exceptionHandling.HandlingException();

            // Custom Exception.
            Console.WriteLine("\n--Custom Exception--");
            CustomException customException = new CustomException();
            customException.ExceptionCustom();

            Console.ReadLine();
        }
    }
}