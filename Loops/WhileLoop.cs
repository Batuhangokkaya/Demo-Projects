using System;

namespace Loops
{
    public class WhileLoop
    {
        public void WhileLoop1()
        {
            int number = 10;
            while (number > 1)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now Number is {0}\n", number);
        }
        
        public void WhileLoop2()
        {
            int number;
            Console.WriteLine("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number % 2 == 0)
            {
                Console.Write("Enter a Number : ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You have entered an odd number.");
        }
    }
}