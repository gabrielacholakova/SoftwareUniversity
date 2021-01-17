using System;

namespace _04._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfTables = double.Parse(Console.ReadLine());
            double lenghtOfTheTables = double.Parse(Console.ReadLine());
            double widthOfTables = double.Parse(Console.ReadLine());

            double tablesArea = countOfTables * (lenghtOfTheTables + 2 * 0.30) * (widthOfTables + 2 * 0.30);
            double quadsArea = (countOfTables * lenghtOfTheTables / 2) * (lenghtOfTheTables / 2);

            double priceInDollars = (tablesArea * 7 ) + (quadsArea * 9);
            double priceInLev = priceInDollars * 1.85;

            Console.WriteLine($"{priceInDollars:F2} USD");
            Console.WriteLine($"{priceInLev:F2} BGN");


        }
    }
}
