using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double allSideWall = (2 * sideWall) - (2 * window);
            double backWall = x * x;
            double door = 1.2 * 2;
            double totalWall = backWall + door;
            double totalArea = 2 * backWall - door;
            double total = allSideWall + totalArea;
            double greenPaint = total / 3.4;

            double roofRectangle = 2 * (x * y);
            double roofTriangle = 2 * (x * h / 2);
            double totalAreaRoof = roofTriangle + roofRectangle;
            double redPaint = totalAreaRoof / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
