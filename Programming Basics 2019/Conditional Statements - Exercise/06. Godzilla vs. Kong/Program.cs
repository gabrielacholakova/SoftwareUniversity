using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());

            double priceForClothes = double.Parse(Console.ReadLine());

            double discount = 0.0;

            double decor = budget / 10;
            double totalClothes = people * priceForClothes;
            if(people >=150)
            {
                discount = totalClothes / 10;
                totalClothes = totalClothes - discount;
            }
            double moneyNeeded = totalClothes + decor;

            if ( moneyNeeded <= budget)
            {
                double moneyLeft = budget - moneyNeeded;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
            else if ( moneyNeeded > budget)
            {
                double money = moneyNeeded - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {money:F2} leva more.");
            }

        }
    }
}
