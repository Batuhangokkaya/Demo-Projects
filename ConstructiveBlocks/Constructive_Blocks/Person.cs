using System;

namespace ConstructiveBlocks.Constructive_Blocks
{
    public class Person
    {
        // Alanlar (fields)
        private string _fullName;
        private int _age;

        // Yapıcı metod (Constructor)
        public Person(string fullName, int age)
        {
            _fullName = fullName;
            _age      = age;
        }

        // Bilgi yazdıran bir metod
        public void PrintInformation()
        {
            Console.WriteLine($"Adı Soyadı : {_fullName}\nYaşı : {_age}");
        }
    }
}