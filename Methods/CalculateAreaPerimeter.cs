namespace Methods
{
    internal class CalculateAreaPerimeter
    {
        // Method 5
        public static double CalculateArea(double shortEdge, double longEdge)
        {
            double area = shortEdge * longEdge;
            return (area);
        }
        public static double CalculatePerimeter(double shortEdge, double longEdge)
        {
            double perimeter = 2 * (shortEdge + longEdge);
            return (perimeter);
        }
    }
}