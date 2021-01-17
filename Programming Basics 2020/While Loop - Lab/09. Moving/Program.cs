using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double volumeOfhome = 0;
            double totalBoxes = 0;

            while (input != "Done")
            {
                double boxes = double.Parse(input);
                volumeOfhome = width * lenght * height;
                totalBoxes += boxes;

                if (totalBoxes > volumeOfhome)
                {
                    double cubicsNeeded = totalBoxes - volumeOfhome;
                    Console.WriteLine($"No more free space! You need {cubicsNeeded} Cubic meters more.");
                    System.Environment.Exit(0);
                }

                input = Console.ReadLine();
            }

            double spaceLeft = volumeOfhome - totalBoxes;
            Console.WriteLine($"{spaceLeft} Cubic meters left.");
        }
    }
}
