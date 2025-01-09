namespace ReCapDemo1
{
    internal class CalculateTotal
    {
        // Dizideki sayıların toplamını hesaplar.
        public int TotalCalculation(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return sum;
        }
    }
}