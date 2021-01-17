using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDogs = int.Parse(Console.ReadLine());
            int othersAnimals = int.Parse(Console.ReadLine());

            double priceForDogs = countOfDogs * 2.50;
            double priceForOthers = othersAnimals * 4.00;

            double total = priceForDogs + priceForOthers;
            Console.WriteLine($"{total} lv.");

        }
    }
}
