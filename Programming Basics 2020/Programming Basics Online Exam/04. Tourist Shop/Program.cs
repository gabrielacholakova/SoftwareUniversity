using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double leftMoney = 0;
            double count = 0;
            double productCounter = 0;
            double allProductCost = 0;
            while (true)
            {
                count++;
                
                string nameOfProduct = Console.ReadLine();
                
                if (nameOfProduct == "Stop")
                {
                    Console.WriteLine($"You bought {productCounter} products for {allProductCost:F2} leva.");
                    break;
                }
                double priceOfProduct = double.Parse(Console.ReadLine());
                
                if (count == 3)
                {
                    priceOfProduct = priceOfProduct / 2;
                    count = 0;
                }

                budget -= priceOfProduct;
                allProductCost += priceOfProduct;
                productCounter++;
                if (budget < 0)
                {
                    double moneyNeeded = budget * -1;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:F2} leva!");
                    break;
                }
            }
        }
    }
}
