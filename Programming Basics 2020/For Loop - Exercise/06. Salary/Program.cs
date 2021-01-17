using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double openTabs = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double penalty = 0;
            double moneyLeft = 0;
            for (int i = 0; i < openTabs ; i++)
            {
                string tabs = Console.ReadLine();
                switch (tabs)
                {
                    case "Facebook": penalty += 150;
                   break;
                    case "Instagram": penalty += 100;
                        break;
                    case "Reddit": penalty += 50;
                        break;
                }
                if (salary <= penalty)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                
            }

            if (salary > penalty)
            {
                moneyLeft = salary - penalty;
                Console.WriteLine(moneyLeft);
            }
        }
    }
}
