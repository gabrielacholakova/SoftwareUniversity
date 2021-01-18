using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regular_Expressions___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            double totalPrice = 0;
            string input = Console.ReadLine();
            var pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";

            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if(match.Success)
                {
                    furniture.Add(match.Groups[1].Value);
                    totalPrice += double.Parse(match.Groups[2].Value) * double.Parse(match.Groups[3].Value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:");
            if (furniture.Count > 0)
            {
                
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
