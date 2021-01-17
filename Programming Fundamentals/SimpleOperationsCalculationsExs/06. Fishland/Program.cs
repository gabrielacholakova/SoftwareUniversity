using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfMackerelKg = double.Parse(Console.ReadLine());
            double priceOfSpratKg = double.Parse(Console.ReadLine());
            double chamoisKg = double.Parse(Console.ReadLine());
            double horseMackerelKg = double.Parse(Console.ReadLine());
            double musselsKg = double.Parse(Console.ReadLine());

            double priceOfChamoisPerKg = priceOfMackerelKg + (priceOfMackerelKg * 0.60);
            double totalPriceOfChamois = chamoisKg * priceOfChamoisPerKg;

            double priceOfHorseMackerel = priceOfSpratKg + (priceOfSpratKg * 0.80);
            double totalPriceOfHorseMackerel = priceOfHorseMackerel * horseMackerelKg;

            double priceOfMussels = musselsKg * 7.50;

            double total = totalPriceOfChamois + totalPriceOfHorseMackerel + priceOfMussels;

            Console.WriteLine($"{total:F2}");


        }
    }
}
