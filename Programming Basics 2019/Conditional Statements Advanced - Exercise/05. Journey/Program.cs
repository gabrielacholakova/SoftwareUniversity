using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            double sum = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    price = (budget / 100) * 30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {price:F2}");
                }
                else if(season == "winter")
                {
                    price = (budget / 100) * 70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {price:F2}");
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    price = (budget / 100) * 40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {price:F2}");
                }
                else if (season == "winter")
                {
                    price = (budget / 100) * 80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {price:F2}");
                }
            }
            else if (budget > 1000)
            {
                price = (budget / 100) * 90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {price:F2}");
            }
        }
    }
}
