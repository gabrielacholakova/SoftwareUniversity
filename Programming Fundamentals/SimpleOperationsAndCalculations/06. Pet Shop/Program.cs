using System;

namespace _06._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDogs = int.Parse(Console.ReadLine());
            int countOfTheOthers = int.Parse(Console.ReadLine());

            double priceFoodDogs = countOfDogs * 2.50;
            double priceForTheOthers = countOfTheOthers * 4;
            double sum = priceFoodDogs + priceForTheOthers;
            Console.WriteLine($"{sum:F2} lv.");
        }
    }
}
