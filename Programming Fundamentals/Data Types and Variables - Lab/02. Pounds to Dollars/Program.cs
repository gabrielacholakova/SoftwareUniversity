using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPound = decimal.Parse(Console.ReadLine());
            decimal usaDollar = britishPound * 1.31m;
            Console.WriteLine($"{usaDollar:F3}");
        }
    }
}
