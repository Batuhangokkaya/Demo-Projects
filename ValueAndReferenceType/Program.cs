using System;

namespace ValueAndReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Değer Tipler    : Integer, Boolean, Inum, Double ve Decimal gibilerdir.
            Referans Tipler : Classlar, Interfacesler, Abstract sınıflar, String ve Arrayler'dir.
            Sonradan veri değişmeyecek ise referans almaya gerek yoktur.
            Referans alındığında Sonradan Veri değişir İse sonuç Değişir.
            */
            // Value Type
            Console.WriteLine("--Value Type--");
            int number1 = 10;
            int number2 = 20;

            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            // Reference Type
            Console.WriteLine("--Reference Type--");
            string[] cities1 = new string[] { "Ankara", "İstanbul", "Samsun" };
            string[] cities2 = new string[] { "Bursa", "Kocaeli", "Balıkesir" };

            cities2 = cities1;
            cities1[0] = "İzmir";
            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }

            Console.ReadKey();
        }
    }
}