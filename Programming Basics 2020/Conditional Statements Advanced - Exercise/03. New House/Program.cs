using System;

namespace _03._New_House
{
    class Program
    {
        static double roses = 5.0;
        static double dahlias = 3.8;
        static double tulips = 2.8;
        static double narcissus = 3.0;
        static double gladiolus = 2.5;


        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double discount = 0;
            double price = 0;
            double sum = 0;
            double total = 0;
            
            if ( type == "Roses")
            {
                if ( quantity > 80)
                {
                    sum -= quantity * roses * 0.10;
                }
                sum += quantity * roses;
            }
            else if ( type == "Dahlias")
            {
                 if(quantity > 90)
                {
                    sum -= quantity * dahlias * 0.15;
                }
                sum += quantity * dahlias;
            }

            else if ( type == "Tulips")
            {
                if (quantity >80)
                {
                    sum -= quantity * tulips * 0.15;
                }
                sum += quantity * tulips;
            }

            else if (type == "Narcissus")
            {
                if (quantity < 120)
                {
                    sum += quantity * narcissus * 0.15;
                }
                sum += quantity * narcissus;
            }

            else if ( type == "Gladiolus")
            {
                if (quantity < 80)
                {
                    sum += quantity * gladiolus * 0.20;
                }
                sum += quantity * gladiolus;
            }

            

            if (sum > budget)
            {
                double moneyNeeded = sum - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:F2} leva more.");
            }
            else if ( sum <= budget)
            {
                double moneyLeft = budget - sum;
                Console.WriteLine($"Hey, you have a great garden with {quantity} {type} and {moneyLeft:F2} leva left.");
            }


        }
    }
}
