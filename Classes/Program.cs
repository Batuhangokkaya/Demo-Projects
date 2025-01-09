using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class1 Sınıfı.
            Class1 class1 = new Class1();
            class1.Add();
            class1.Remove();
            class1.Update();

            // Customer Sınıfı.
            // Customer Örnek 1.
            Customer customer1 = new Customer();
            customer1.Id        = 1;
            customer1.FirstName = "Batuhan";
            customer1.LastName  = "Gökkaya";
            customer1.City      = "Kocaeli";

            Console.WriteLine($"Id : {customer1.Id}, First Name : {customer1.FirstName}, Last Name : {customer1.LastName}, City : {customer1.City}.");

            // Customer örnek 2.
            Customer customer2 = new Customer()
            {
                Id        = 2,
                FirstName = "Yasemin",
                LastName  = "Gökkaya",
                City      = "Kocaeli"
            };

            Console.WriteLine($"Id : {customer2.Id}, First Name : {customer2.FirstName}, Last Name : {customer2.LastName}, City : {customer2.City}.\n");

            // BankAccount Sınıfı.
            BankAccount bankAccount = new BankAccount
            {
                Balance = 4000,
            };
            Console.WriteLine($"Balance : {bankAccount.Balance}");

            string accountNo = "1234567890";
            bankAccount.SetAccountNo(accountNo); // Hesap numarası eklemek için set ettim.

            string getAccountNo = bankAccount.GetAccountNo(); // Hesap numarasını geriye döndürdüm.
            Console.WriteLine(getAccountNo);

            // PartialClass Sınıfı.
            // Partial Örnek 1.
            PartialClass partialClass1 = new PartialClass();
            partialClass1.FirstName = "Batuhan";
            partialClass1.LastName  = "Gökkaya";
            Console.WriteLine($"First Name : {partialClass1.FirstName}, Last Name : {partialClass1.LastName}.");

            int number1 = partialClass1.number1();
            int number2 = partialClass1.number2();
            Console.WriteLine($"Number 1 : {number1}, Number 2 : {number2}.");

            // Partial Örnek 2.
            PartialClass partialClass2 = new PartialClass
            {
                FirstName = "Yasemin",
                LastName  = "Gökkaya"
            };
            Console.WriteLine($"First Name : {partialClass2.FirstName}, Last Name : {partialClass2.LastName}.");
            int number3 = partialClass2.number1();
            int number4 = partialClass2.number2();
            Console.WriteLine($"Number 3 : {number3}, Number 4 : {number4}.");

            Console.ReadLine();
        }
    }
}