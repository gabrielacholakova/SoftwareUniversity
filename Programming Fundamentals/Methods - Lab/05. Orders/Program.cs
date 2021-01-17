using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            Sum(product , quantity);

        }
        static void Sum ( string product, decimal quantity )
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(quantity * 1.50m);
                    break;
                case "water":
                    Console.WriteLine(quantity * 1.00m);
                    break;
                case "coke":
                    Console.WriteLine(quantity * 1.40m);
                    break;
                case "snacks":
                    Console.WriteLine(quantity * 2.00m);
                    break;
            }
        }
    }
}
