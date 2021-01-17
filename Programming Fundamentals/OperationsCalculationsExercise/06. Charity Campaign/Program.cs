using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfCampaign = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofres = int.Parse(Console.ReadLine());
            int crepes = int.Parse(Console.ReadLine());

            double cakesPerDay = 45 * cakes;
            double gofresPerDay = 5.80 * gofres;
            double crepesPerDay = 3.20 * crepes;

            double sumPerDay = (cakesPerDay + gofresPerDay + crepesPerDay) * chefs;
            double totalSumOfCompaign = sumPerDay * daysOfCampaign;
            double totalSum = totalSumOfCompaign - (totalSumOfCompaign / 8);

            Console.WriteLine($"{totalSum:F2}");

        }
    }
}
