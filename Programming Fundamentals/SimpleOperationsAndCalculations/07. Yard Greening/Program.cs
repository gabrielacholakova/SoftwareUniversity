using System;

namespace _07._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double greeningMetersNeeded = double.Parse(Console.ReadLine());

            double priceForGreening = greeningMetersNeeded * 7.61;
            double discount = priceForGreening * 0.18;

            double totalSum = priceForGreening - discount;

            Console.WriteLine($"The final price is: {totalSum:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");

        }
    }
}
