using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double moneyBalance = double.Parse(Console.ReadLine());
            double days = 0;
            double daysSpend = 0;
            double totalDays = 0;

            while (true)
            {
                days++;
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    daysSpend++;
                   
                    if (daysSpend == 5 )
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{days}");
                        System.Environment.Exit(0);
                    }
                    moneyBalance -= money;

                    if (moneyBalance <= 0)
                    {
                        moneyBalance = 0;

                    }
                }
                if (action == "save")
                {
                    daysSpend = 0;
                    moneyBalance += money;
                  
                }
              
                if (vacationPrice <= moneyBalance )
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    System.Environment.Exit(0);
               }

                
            }
         
              

        }
    }
}
