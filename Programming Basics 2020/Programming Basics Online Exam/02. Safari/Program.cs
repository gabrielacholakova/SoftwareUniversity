using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double discount = 0;
            double fuelNeeded = fuel * 2.10;
            double guide = fuelNeeded + 100;

            if (day == "Saturday")
            {
                discount = guide - ((guide / 100) * 10);
            }
            else if (day == "Sunday")
            {
                discount = guide - ((guide / 100) * 20);
            }
            if (budget < discount)
            {
                double moneyNeeded = discount - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:F2} lv.");
            }
            else if (budget > discount)
            {
                double moneyLeft = budget - discount;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:F2} lv. ");
            }
        }
    }
}
