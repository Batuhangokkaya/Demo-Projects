namespace ReCapDemo1
{
    internal class AverageCalculation
    {
        // Dizideki sayıların ortalamasını hesaplar.
        public double CalculateAverage(int[] array)
        {
            CalculateTotal calculateTotal = new CalculateTotal();
            int sum = calculateTotal.TotalCalculation(array);
            return (double)sum / array.Length;
        }
    }
}