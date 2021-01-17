using System;

namespace _07._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfwhiskey = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double priceOfrakia = priceOfwhiskey / 2;
            double priceOFwine = priceOfrakia - (0.4 * priceOfrakia);
            double priceOfBeer = priceOfrakia - (0.8 * priceOfrakia);

            double totalPriceRakia = rakiaLiters * priceOfrakia;
            double totalPriceWine = wineLiters * priceOFwine;
            double totalPriceBeer = priceOfBeer * beerLiters;
            double totalPriceWhiskey = priceOfwhiskey * whiskeyLiters;

            double sum = totalPriceBeer + totalPriceRakia + totalPriceWhiskey + totalPriceWine;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
