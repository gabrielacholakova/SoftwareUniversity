using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double countOfBananas = double.Parse(Console.ReadLine());
            double countOfOrange = double.Parse(Console.ReadLine());
            double countOfRaspberries = double.Parse(Console.ReadLine());
            double countOfstrawberries = double.Parse(Console.ReadLine());

            double priceOfRaspberries = strawberriesPrice / 2;
            double priceOfOrange = priceOfRaspberries - (0.4 * priceOfRaspberries);
            double priceOfBananas = priceOfRaspberries - (0.8 * priceOfRaspberries);
            double raspberriesSum = countOfRaspberries * priceOfRaspberries;
            double orangeSum = countOfOrange * priceOfOrange;
            double bananasSum = countOfBananas * priceOfBananas;
            double strawberriesSum = countOfstrawberries * strawberriesPrice;

            double totalSum = raspberriesSum + orangeSum + bananasSum + strawberriesSum;

            Console.WriteLine(totalSum);
        }
    }
}
