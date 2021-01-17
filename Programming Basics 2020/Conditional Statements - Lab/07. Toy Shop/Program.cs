using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double countOfPuzzles = double.Parse(Console.ReadLine());
            double countOfDolls = double.Parse(Console.ReadLine());
            double countOfBears = double.Parse(Console.ReadLine());
            double countOfMinions = double.Parse(Console.ReadLine());
            double countOfTrucks = double.Parse(Console.ReadLine());
            
            double sum = (countOfPuzzles * 2.6) + (countOfDolls * 3) + (countOfBears * 4.10) + (countOfMinions * 8.20) + (countOfTrucks * 2);
            double countOfToys = countOfPuzzles + countOfDolls + countOfBears + countOfMinions + countOfTrucks;

            if (countOfToys >= 50)
            {
                double discount = (sum / 100) * 25;
                double priceAfterDiscount = sum - discount;
                double rent = priceAfterDiscount / 10;
                double profit = priceAfterDiscount - rent;
                if( profit >= vacationPrice)
                {
                    double moneyLeft = profit - vacationPrice;
                    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
                }
                else
                {
                    double moneyNeeded = vacationPrice - profit;
                    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
                }
            }
            else
            {
                double rent = sum / 10;
                double profit = sum - rent;
                if (profit > vacationPrice)
                {
                    double moneyLeft = profit - vacationPrice;
                    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
                }
                else
                {
                    double moneyNeeded = vacationPrice - profit;
                    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
                }
            }

            
            
        }
    }
}
