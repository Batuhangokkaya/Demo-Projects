using System;

namespace ReCapDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetANumber getANumber                 = new GetANumber();
            CalculateTotal calculateTotal         = new CalculateTotal();
            AverageCalculation averageCalculation = new AverageCalculation();
            FindingEvenNumbers findingEvenNumbers = new FindingEvenNumbers();
            FindingOddNumbers findingOddNumbers   = new FindingOddNumbers();
            FindLargestNumber findLargestNumber   = new FindLargestNumber();
            FindSmallestNumber findSmallestNumber = new FindSmallestNumber();
            SortArray sortArray                   = new SortArray();

            Console.Write("How many elements do you want to create an array? : ");
            int numberElements = getANumber.GetNumber(); // Kullanıcıdan dizi boyutunu alıyoruz.

            int[] numbers = new int[numberElements];
            Console.WriteLine("Please enter the elements of the array.");

            // Kullanıcıdan dizi elemanlarını alıyoruz.
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write($"[{i + 1}] element : ");
                numbers[i] = getANumber.GetNumber(); // Girdi doğrulama metodu ile sayı alımı.
            }

            // İşlemleri gerçekleştiren metotları çağırıyoruz.
            int sum               = calculateTotal.TotalCalculation(numbers);
            double average        = averageCalculation.CalculateAverage(numbers);
            int[] evenNumbers     = findingEvenNumbers.FindEvenNumbers(numbers);
            int[] oddNumbers      = findingOddNumbers.FindOddNumbers(numbers);
            int maxValue          = findLargestNumber.LargestNumber(numbers);
            int minValue          = findSmallestNumber.SmallestNumber(numbers);
            int[] sequentialArray = sortArray.ArraySort(numbers);

            // Sonuçları yazdırıyoruz.
            Console.WriteLine("\n--- Analysis Results ---");
            Console.WriteLine($"sum : {sum}");
            Console.WriteLine($"Average : {average:F2}");
            Console.WriteLine($"Even Numbers : {string.Join(", ", evenNumbers)}");
            Console.WriteLine($"Odd Numbers : {string.Join(", ", oddNumbers)}");
            Console.WriteLine($"Max Value : {maxValue}");
            Console.WriteLine($"Min Value : {minValue}");
            Console.WriteLine($"Sequential Array : {string.Join(", ", sequentialArray)}");

            Console.ReadLine();
        }
    }
}