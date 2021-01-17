using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double  n1 = double.Parse(Console.ReadLine());
            double  n2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;

            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
                return;
            }

            if (symbol == "+" || symbol == "-" ||symbol == "*")
            {
                if ( symbol == "+")
                {
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else if (result % 2 !=0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }

                }
                else if (symbol == "-")
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else if(result % 2 != 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }

                }
                else if (symbol == "*")
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else if (result % 2 !=0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                }

            }
            else if ( symbol == "/")
            {
                result = n1 / n2;
                if (result % 2 == 0)
                {
                   // Console.WriteLine($"{n1} / {n2} = {result:F2}");
                   Console.WriteLine($"{n1} / {n2} = {result:F2} - even");
                }
                else if(result % 2 != 0)
                {
                    Console.WriteLine($"{n1} / {n2} = {result:F2}");
                }
                else
                {
                   Console.WriteLine($"{n1} / {n2} = {result:F2} - odd");
                }
            }
            else if (symbol == "%")
            {
                result = n1 % n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
                else
                {
                    Console.WriteLine($"{n1} % {n2} = {result} - odd");
                }
            }
            

        }
    }
}
