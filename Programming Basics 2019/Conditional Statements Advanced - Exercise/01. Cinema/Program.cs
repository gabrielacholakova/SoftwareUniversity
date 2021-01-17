using System;

namespace Conditional_Statements_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double colums = double.Parse(Console.ReadLine());
            double income = 0.0;
            if (type == "Premiere")
            {
                income = rows * colums * 12;
            }
            else if ( type == "Normal")
            {
                income = rows * colums * 7.50;
            }
            else if ( type == "Discount")
            {
                income = rows * colums * 5.00;
            }

            Console.WriteLine($"{income:F2} leva");



        }
    }
}
