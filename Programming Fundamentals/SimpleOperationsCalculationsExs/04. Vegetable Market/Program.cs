using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitsKg = double.Parse(Console.ReadLine());

            double totalVegetables = vegetablePrice * vegetableKg;
            double totalFruits = fruitsPrice * fruitsKg;

            double vegetablesAndFruits = totalFruits + totalVegetables;
            double totalSum = vegetablesAndFruits / 1.94;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
