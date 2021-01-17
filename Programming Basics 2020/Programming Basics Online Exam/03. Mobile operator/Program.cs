using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string termOfContract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string internetAdded = Console.ReadLine();
            double countOfMonths = double.Parse(Console.ReadLine());
            double priceForMonth = 0;
            double internetPrice = 0;
            double totalMoney = 0;
            double sum = 0;
            double totalSum = 0;
            if (termOfContract == "one")
            {
                switch (typeOfContract)
                {
                    case "Small":
                        priceForMonth = 9.98;
                        break;
                    case "Middle":
                        priceForMonth = 18.99;
                        break;
                    case "Large":
                        priceForMonth = 25.98;
                        break;
                    case "ExtraLarge":
                        priceForMonth = 35.99;
                        break;
                }
                if (internetAdded == "yes")
                {
                    if (priceForMonth <= 10)
                    {
                        internetPrice = 5.50;
                    }
                    else if (priceForMonth <= 30 && priceForMonth > 10)
                    {
                        internetPrice = 4.35;
                    }
                    else if (priceForMonth > 30)
                    {
                        internetPrice = 3.85;
                    }
                }
               
                totalMoney = priceForMonth + internetPrice;
                sum = totalMoney * countOfMonths;
                Console.WriteLine($"{sum:F2} lv.");
            }
            else if (termOfContract == "two")
            {
                switch (typeOfContract)
                {
                    case "Small":
                        priceForMonth = 8.58;
                        break;
                    case "Middle":
                        priceForMonth = 17.09;
                        break;
                    case "Large":
                        priceForMonth = 23.59;
                        break;
                    case "ExtraLarge":
                        priceForMonth = 31.79;
                        break;
                }

                if (internetAdded == "yes")
                {
                    if (priceForMonth <= 10)
                    {
                        internetPrice = 5.50;
                    }
                    else if (priceForMonth <= 30 && priceForMonth > 10)
                    {
                        internetPrice = 4.35;
                    }
                    else if (priceForMonth > 30)
                    {
                        internetPrice = 3.85;
                    }
                }
                
                totalMoney = priceForMonth + internetPrice;
                totalSum = totalMoney - ((totalMoney / 100) * 3.75);
                sum = totalSum * countOfMonths;
                Console.WriteLine($"{sum:F2} lv.");
            }
            
        }
    }
}
