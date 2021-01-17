using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfDays = double.Parse(Console.ReadLine());
            double numOfChefs = double.Parse(Console.ReadLine());
            double numOfCakes = double.Parse(Console.ReadLine());
            double numOfGofres = double.Parse(Console.ReadLine());
            double numOfCrepes = double.Parse(Console.ReadLine());

            double cakes = numOfCakes * 45;
            double gofres = numOfGofres * 5.80;
            double crepes = numOfCrepes * 3.20;
            double sumPerDay = (cakes + gofres + crepes) * numOfChefs;
            double moneyRaised = sumPerDay * numOfDays;
            double finalSum = moneyRaised - (moneyRaised /8); 

            Console.WriteLine(finalSum);


        }
    }
}
