using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fishermen = double.Parse(Console.ReadLine());
            double priceBoat = 0;
            double discount = 0;
            double sum = 0;
            double moreDiscount = 0;
            double moneyLeft = 0;
            double moneyNeeded = 0;

            if (season == "Spring")
            {
                priceBoat = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceBoat = 4200;
            }
            else if (season == "Winter")
            {
                priceBoat = 2600;
            }
            if (fishermen <= 6)
            {
                discount = (priceBoat / 100) * 10;
                sum = priceBoat - discount;
            }
            else if ( fishermen >=7 && fishermen <=11)
            {
                discount = (priceBoat / 100) * 15;
                sum = priceBoat - discount;
            }
            else if (fishermen > 12)
            {
                discount = (priceBoat / 100) * 25;
                sum = priceBoat - discount;
            }
            if (fishermen % 2 == 0 )
            {
                if(season == "Spring" || season == "Summer" ||season == "Winter")
                moreDiscount = (sum / 100) * 5;
                sum = sum - moreDiscount;
            }
            
            if (budget >= sum)
            {
                moneyLeft = budget - sum;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else if (sum > budget)
            {
                moneyNeeded = sum - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
            }
        }
    }
}
