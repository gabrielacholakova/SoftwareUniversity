using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string opinion = Console.ReadLine();
            double price = 0;
            double moneyNeeded = 0;
            double discount = 0;
            double moneyAfterdiscount = 0;
            double moreDiscount = 0;
            double totalSum = 0;

            if ( type == "room for one person")
            {
                price = 18.00;
                moneyNeeded = (days * price) - price;
                if (opinion == "positive")
                {
                    discount = (moneyNeeded / 100) * 25;
                    totalSum = discount + moneyNeeded;
                }
               else if (opinion == "negative")
                {
                    discount = (moneyNeeded / 100) * 10;
                    totalSum = moneyNeeded - discount;
                }
                
                Console.WriteLine($"{totalSum:F2}");
                return;
                
            }
            else if (type == "apartment")
            {
                price = 25.00;
                moneyNeeded = (days * price) - price;
                if (days < 10)
                {
                    discount = (moneyNeeded / 100) * 30;
                    moneyAfterdiscount = moneyNeeded - discount;
                }
                else if (days > 10 && days <= 15)
                {
                    discount = (moneyNeeded / 100) * 35;
                    moneyAfterdiscount = moneyNeeded - discount;
                }
                else if (days > 15)
                {
                    discount = (moneyNeeded / 100) * 50;
                    moneyAfterdiscount = moneyNeeded - discount;
                }
            }
            else if (type == "president apartment")
            {
                price = 35.00;
                moneyNeeded = (days * price) - price;
                if (days < 10)
                {
                    discount = (moneyNeeded / 100) * 10;
                    moneyAfterdiscount = moneyNeeded - discount;
                }
                else if (days > 10 && days <= 15)
                {
                    discount = (moneyNeeded / 100) * 15;
                    moneyAfterdiscount = moneyNeeded - discount;
                }
                else if (days > 15)
                {
                    discount = (moneyNeeded / 100) * 20;
                    moneyAfterdiscount = moneyNeeded - discount;
                }
            }


            if (opinion == "positive")
            {
                moreDiscount = (moneyAfterdiscount / 100) * 25;
                totalSum = moneyAfterdiscount + moreDiscount;
            }
            else if (opinion == "negative")
            {
                moreDiscount = (moneyAfterdiscount / 100) * 10;
                totalSum = moneyAfterdiscount - moreDiscount;
            }

            Console.WriteLine($"{totalSum:F2}");

            


        }
    }
}
