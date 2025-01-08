using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[8];
            names[0] = "Asuman";
            names[1] = "Cüneyt";
            names[2] = "Batuhan";;
            names[5] = "Burak";
            names[6] = "Yasemin";

            Array.Clear(names, 4, 4); // Değişken türü string ise " " boş ekler. int ise 0 ekler.
            Array.Sort(names);        // Değişken türü string ise A'dan Z'ye sıralar. int ise küçükten büyüğe sıralar.
            Array.Reverse(names);     // Diziyi tersten yazdırır.

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("{0}", names.Length);               // .Length        : Dizinin kaç elemanlı olduğunu gösterir.
            Console.WriteLine(Array.IndexOf(names, "Asuman"));    // .IndexOf()     : Dizinin istenilen elemanın baştan başlayarak sırasını gösterir.
            Console.WriteLine(Array.LastIndexOf(names, "Miray")); // .LastIndexOf() : Dizinin istenilen elemanın sondan başlayarak sırasını gösterir.

            Console.WriteLine();

            string[] colors = { "Purple", "White", "Red", "Aqua" }; // new [] olmadanda yazılabilir.
            colors[0] = "Black"; // Değiştirelebilir ama eklenemez.
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(colors[i]);
            }

            Console.WriteLine();

            /* Çok Boyutlu Dizi */
            string[,] regions = new string[5, 2]
            {
                {"İstanbul", "İzmit"},
                {"Ankara", "Konya"},
                {"Antalya", "Adana"},
                {"Rize", "Samsun"},
                {"İzmir", "Manisa"},
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }
                Console.WriteLine("--------");
            }


            Console.WriteLine();


            string[,] car = new string[2, 2];
            car[0, 0] = "Volkswagen";
            car[0, 1] = "Golf";
            car[1, 0] = "BMW";
            car[1, 1] = "İ8";
            for (int i = 0; i <= car.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= car.GetUpperBound(1); j++)
                {
                    Console.WriteLine(car[i, j]);
                }
                Console.WriteLine("--------");
            }


            Console.WriteLine();


            string[] students = new string[5] { "Cüneyt", "Asuman  ", "Batuhan  ", "Burak ", "Yasemin  " };
            int[,] notes = new int[5, 3] { { 70, 70, 70 }, { 100, 50, 100 }, { 50, 50, 50 }, { 100, 100, 100 }, { 50, 70, 51 } };
            int n = 0;
            for (int i = 0; i <= 4; i++)
            {
                int average = (notes[i, n + 0] + notes[i, n + 1] + notes[i, n + 2]) / 3;
                Console.WriteLine("{0} Learner's Average : {1}", students[i], average);
            }


            Console.WriteLine();


            int[] numbers = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.Write((i + 1).ToString() + ".Enter the Number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest;
            largest = numbers[0];
            for (int i = 0; i <= 4; i++)
            {
                if (largest < numbers[i])
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine(largest);//
        }
    }
}