using System;

namespace Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            decimal kilometers = number * 0.001m;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
