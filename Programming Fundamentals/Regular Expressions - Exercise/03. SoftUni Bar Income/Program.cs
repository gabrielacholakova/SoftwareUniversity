using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            
            double totalPrice = 0;
            double totalSum = 0;
           
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                if(Regex.IsMatch(input,pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var customer = match.Groups["customer"].Value;
                    var product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    totalPrice = quantity * price;
                    totalSum += totalPrice;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");
                }

             }
            Console.WriteLine($"Total income: {totalSum:F2}");

            



        }
    }
}
