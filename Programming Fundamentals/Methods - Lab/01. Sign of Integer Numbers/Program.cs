using System;

namespace Methods___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TypeOfNum(n);
        }

        static void TypeOfNum(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
        }
    }
}
