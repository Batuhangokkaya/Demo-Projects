using ConstructiveBlocks.Base_Constructor;
using ConstructiveBlocks.Constructive_Blocks;
using ConstructiveBlocks.Constructive_Injection;
using ConstructiveBlocks.Static_Classes;
using System;

namespace ConstructiveBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person
            Console.WriteLine("--Person Constructor--");
            string _fullName = "Batuhan GÖkkaya";
            int _age         = 24;

            Person person = new Person(_fullName, _age);
            person.PrintInformation();

            Console.WriteLine();

            // EmployeeManager
            Console.WriteLine("--Person Constructor Injection--");
            DatabaseLogger databaseLogger   = new DatabaseLogger();
            FileLogger fileLogger           = new FileLogger();
            EmployeeManager employeeManager = new EmployeeManager(databaseLogger);
            employeeManager.Add();

            Console.WriteLine();

            // PersonManager
            Console.WriteLine("--PersonManager Base Constructor--");
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.WriteLine();

            // Static Class
            /*
            Örneklenemezler
            Tüm üyeleri statik olmak zorundadır
            Doğrudan sınıf adıyla erişilir
            Static Constructor'a sahiptirler (Parametre alamaz)
            Miras alınamaz ve türetilemez
            Başlangıç değeri otomatik atanır
            Bellek kullanımı tekildir
            Utility (yardımcı) sınıfları için uygundur
            Namespace içinde kullanılabilirler
            Birden fazla static üye destekler
            */
            Console.WriteLine("--Static Class--");
            StaticClassTeacher.Number = 10;
            StaticClassTeacher.PrintNumber();

            StaticClassUtilities.PrintInformation();
            Console.ReadLine();
        }
    }
}