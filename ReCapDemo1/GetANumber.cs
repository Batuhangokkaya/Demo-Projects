using System;

namespace ReCapDemo1
{
    public class GetANumber
    {
        // Kullanıcıdan geçerli bir sayı alır.
        public int GetNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter a valid number.");
            }
            return number;
        }
    }
}