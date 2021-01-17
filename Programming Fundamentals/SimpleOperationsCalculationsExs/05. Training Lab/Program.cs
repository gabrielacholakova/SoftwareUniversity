using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double rows = Math.Floor(((h * 100) - 100) / 70); 
            double places = Math.Floor(w * 100 / 120);
            double workPlaces = rows * places - 3;
            Console.WriteLine("{0:F0}", workPlaces);

        }
    }
}
