using System.Linq;

namespace ReCapDemo1
{
    internal class SortArray
    {
        // Diziyi sıralar.
        public int[] ArraySort(int[] array)
        {
            return array.OrderBy(number => number).ToArray(); // LINQ kullanımı
        }
    }
}