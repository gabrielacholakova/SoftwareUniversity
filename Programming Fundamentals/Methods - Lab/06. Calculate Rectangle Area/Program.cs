using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Area(width,height);
        }
        static void Area(int width, int height)
        {
            int area = width * height;
            Console.WriteLine(area);
        }
    }
}
