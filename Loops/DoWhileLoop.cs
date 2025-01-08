using System;

namespace Loops
{
    internal class DoWhileLoop
    {
        public void DoWhileLoop1()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 1);
        }

        public void DoWhileLoop2()
        {
            string username = "b", password = "g";
            string inputUsername, inputPassword;
            int right = 4;
            do
            {
                Console.Write("Enter your username : ");
                inputUsername = Console.ReadLine();
                Console.Write("Enter your password : ");
                inputPassword = Console.ReadLine();
                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    right--;
                    if (right == 0)
                    {
                        Console.Write("You have entered your username or password incorrectly 4 times. Please try again later..");
                    }
                    else
                    {
                        Console.WriteLine("You entered your username or password incorrectly. Please try again.");
                    }
                }
            } while ((inputUsername != username || inputPassword != password) && right != 0);
        }

        public void DoWhileLoop3()
        {
            int number;
            int sum = 0;
            do
            {
                Console.Write("Please enter number : ");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            } while (number != 0);
            Console.WriteLine("Sum of numbers : {0}", sum);
        }

        public void DoWhileLoop4()
        {
            Random rnd = new Random();
            int numberOfProduced = rnd.Next(10, 15);
            int number;
            int right = 5;
            Console.Write("Make an estimate : ");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                right--;
                if (right == 0)
                {
                    Console.WriteLine("Your Right Is Over.");
                    break;
                }
                if (number == numberOfProduced)
                {
                    Console.Write("Congratulations.");
                }
                else if (number < numberOfProduced)
                {
                    Console.Write("Enter a large number : ");
                }
                else if (number > numberOfProduced)
                {
                    Console.Write("Enter a small number : ");
                }
            } while (number != numberOfProduced && right != 0);
        }
    }
}