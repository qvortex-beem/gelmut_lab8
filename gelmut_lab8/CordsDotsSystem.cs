class CordsDotsSystem
{
    public struct Point2D
    {
        public int X;
        public int Y;

        public Point2D(int x, int y)
        {
            X = x; 
            Y = y;
        }

        public double DistanceTo(Point2D other)
        {
            int dx = X - other.X;
            int dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy); 
        }
    }

    static void Main(string[] args)
    {
        var p1 = new Point2D(10, 20);
        var p2 = new Point2D(13, 24);
        Console.WriteLine($"Расстояние: {p1.DistanceTo(p2):F2}");
    }
}
