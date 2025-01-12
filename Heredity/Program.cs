using System;

namespace Heredity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Batuhan";

            Console.WriteLine("--Intheritance--");
            // 1. Kullanım
            Person[] persons1 = new Person[3]
            {
                new Customer{ FirstName = "Yasemin" }, new Student{ FirstName = "Batuhan" }, new Person{ FirstName = "Burak" }
            };
            foreach (var person in persons1)
            {
                Console.WriteLine(person.FirstName);
            }

            // 2. Kullanım
            Customer customer1 = new Customer
            {
                Id        = 1,
                FirstName = "Batuhan",
                LastName  = "Gökkaya",
                City      = "Kocaeli",
            };

            Customer customer2 = new Customer
            {
                Id        = 1,
                FirstName = "Batuhan",
                LastName  = "Gökkaya",
                City      = "Kocaeli",
            };

            Customer customer3 = new Customer
            {
                Id        = 1,
                FirstName = "Batuhan",
                LastName  = "Gökkaya",
                City      = "Kocaeli",
            };

            Person[] persons2 = new Person[3]
            {
                customer1,
                customer2,
                customer3
            };

            Console.WriteLine();

            // Virtual Methods
            Console.WriteLine("--Virtual Methods--");
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();

            Console.WriteLine();

            OracleServer oracleServer = new OracleServer();
            oracleServer.Add();
            oracleServer.Delete();

            Console.ReadLine();
        }
    }
}