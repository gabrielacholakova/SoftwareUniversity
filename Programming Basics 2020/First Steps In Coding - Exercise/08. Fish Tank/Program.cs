using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * hight;
            double liters = volume * 0.001;
            double litersNeeded = liters * (1 - (percent * 0.01));

            Console.WriteLine(litersNeeded);

        }
    }
}
