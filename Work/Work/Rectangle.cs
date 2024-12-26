using Work.Interfaces;

namespace Work
{
    public class Rectangle : IRectangle
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle, Length: {Length}, " +
                $"Width: {Width}, Area: {Area:F2}");
        }
    }
}
