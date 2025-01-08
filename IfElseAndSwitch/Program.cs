using System;

namespace IfElseAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else
            // if-else
            Console.Write("Enter a Number 1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a Number 2 : ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"the number1 is equal to the number2 : {number1} = {number2}");
            }
            else if (number1 > number2)
            {
                Console.WriteLine($"the number 1 is greater than the number 2 : {number1} > {number2}");
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"the number 1 is smaller than the number 2 : {number1} < {number2}\n\n");
            }
            #endregion

            #region Switch-Case
            // switch-case
            Console.Write("Enter a Day : ");
            BTTB:
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    {
                        Console.WriteLine($"Entered day : {day}. weekdays.");
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    {
                        Console.WriteLine($"Entered day : {day}. weekend.");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid day");
                    goto BTTB; // Back to the beginning
            }
            #endregion

            Console.ReadKey();
        }
    }
}