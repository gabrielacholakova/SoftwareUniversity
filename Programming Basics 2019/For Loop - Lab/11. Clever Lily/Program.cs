using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());
            double toys = 0;
            double money = 0;
            double moneySaved = 0;
            double brotherMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    toys++;
                }
                else if (i % 2 == 0)
                {
                    money+=10;
                    moneySaved += money;
                    brotherMoney += 1;

                }
            }

            double moneyFromToys = toys * pricePerToy;
            double totalMoney = moneySaved + moneyFromToys - brotherMoney;

            if (totalMoney >= washingMashinePrice)
            {
                double moneyLeft = totalMoney - washingMashinePrice;
                Console.WriteLine($"Yes! {moneyLeft:F2}");
            }
            else if (totalMoney < washingMashinePrice)
            {
                double moneyNeeded = washingMashinePrice - totalMoney;
                Console.WriteLine($"No! {moneyNeeded:F2}");
            }
        }
    }
}
