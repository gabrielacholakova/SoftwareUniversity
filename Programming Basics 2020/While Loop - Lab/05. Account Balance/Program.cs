using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);
                

                if (money < 0 )
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:F2}");
                    System.Environment.Exit(0);
                }
                sum += money;

                Console.WriteLine($"Increase: {money:F2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
