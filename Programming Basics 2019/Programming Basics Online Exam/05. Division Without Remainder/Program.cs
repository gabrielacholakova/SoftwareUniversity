using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;


            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1 += 1;
                }
                if (num % 3 == 0)
                {
                    p2 += 1;
                }
                if (num % 4 == 0)
                {
                    p3 += 1;
                }
            }

            double percentP1 = (p1 / n) * 100;
            double percentP2 = (p2 / n) * 100;
            double percentP3 = (p3 / n) * 100;
            Console.WriteLine($"{percentP1:F2}%");
            Console.WriteLine($"{percentP2:F2}%");
            Console.WriteLine($"{percentP3:F2}%");
        }
    }
}
