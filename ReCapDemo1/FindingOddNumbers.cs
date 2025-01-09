using System.Linq;

namespace ReCapDemo1
{
    public class FindingOddNumbers
    {
        // Dizideki tek sayıları bulur.
        public int[] FindOddNumbers(int[] array)
        {
            return array.Where(number => number % 2 != 0).ToArray(); // LINQ kullanımı
        }
    }
}