using System.Linq;

namespace ReCapDemo1
{
    public class FindingEvenNumbers
    {
        // Dizideki çift sayıları bulur.
        public int[] FindEvenNumbers(int[] array)
        {
            return array.Where(number => number % 2 == 0).ToArray(); // LINQ kullanımı
        }
    }
}