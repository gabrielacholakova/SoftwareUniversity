using System;

namespace _05._Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double danceHallInCm2 = (L * 100) * (w * 100);
            double wardrobe = a * 100;
            double sizeOfWardeobe = wardrobe * wardrobe;
            double sizeOfBench = danceHallInCm2 / 10;
            double freeSpace = danceHallInCm2 - sizeOfBench - sizeOfWardeobe;
            double dancers = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
