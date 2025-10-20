using homework.Models;
using System.Drawing;
using System.Runtime.InteropServices;
namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            //Car car1 = new Car();
            //car1.Brand = "бред1";
            //car1.Model = "модель1";
            //car1.Year = 1;
            //car1.Mileage = 1;
            //Car car2 = new Car();
            //car2.Brand = "бред2";
            //car2.Model = "модель2";
            //car2.Year = 1;
            //car2.Mileage = 1;
            //car1.PrintInfo();
            //car2.PrintInfo();

            // задание 2
            //User user = new User();
            //user.Name = "Test";
            //user.Email = "Test";
            //user.IsActive = true;
            //Console.WriteLine($"{user.Name}, {user.Email}, {user.IsActive}");

            // задание 3
            //ValueChecker.CheckType(5);
            //ValueChecker.CheckType("Hello");

            // задание 4
            //global::System.Console.WriteLine();

            // задание 5
            //Rectangle rectangle = new Rectangle();
            //rectangle.Position = new();
            //rectangle.Position.X = 10;
            //rectangle.Position.Y = 10;
            //rectangle.Width = 20;
            //rectangle.Height = 15;
            //Console.WriteLine($"Прямоугольник: позиция ({rectangle.Position.X},{rectangle.Position.Y}), ширина {rectangle.Width}, высота {rectangle.Height}");
            //Console.WriteLine($"Площадь: {rectangle.CalculateArea()}");
            //Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}");
            //Console.WriteLine();

            //Poin point1 = new Poin();
            //point1.X = 15;
            //point1.Y = 15;
            //Poin point2 = new Poin();
            //point2.X = 5;
            //point2.Y = 5;
            //Console.WriteLine($"Точка ({point1.X},{point1.Y}) {rectangle.ContainsPoint(point1)}");
            //Console.WriteLine($"Точка ({point2.X},{point2.Y}) {rectangle.ContainsPoint(point2)}");

        }

        struct Rectangle
        {
            public int Width {  get; set; }
            public int Height { get; set; }
            public Poin Position = new Poin();

            public Rectangle()
            {
            }

            public int CalculateArea()
            {
                return Width * Height;
            }
            public int CalculatePerimeter()
            {
                return 2 * (Height + Width);
            }
            public bool ContainsPoint(homework.Program.Poin point)
            {
                if (point.X > Position.X &&  Position.X+Width > point.X)
                {
                    if (point.Y > Position.Y && Position.Y + Height > point.Y)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        struct Poin
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
