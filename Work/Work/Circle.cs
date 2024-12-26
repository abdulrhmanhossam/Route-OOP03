using Work.Interfaces;

namespace Work
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius *  Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }



        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle, Radius: {Radius}, Area: {Area:F2}");
        }
    }
}
