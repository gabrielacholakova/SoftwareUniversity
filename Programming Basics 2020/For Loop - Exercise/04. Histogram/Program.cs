using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double percentP1 = 0;
            double percentP2 = 0;
            double percentP3 = 0;
            double percentP4 = 0;
            double percentP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num <200)
                {
                    p1 += 1;
                }
                else if (num >= 200 && num < 400)
                {
                    p2 += 1;
                }
                else if ( num >=400 && num < 600)
                {
                    p3 += 1;
                }
                else if ( num >= 600 && num < 800)
                {
                    p4 += 1;
                }
                else if (num >= 800 && num <= 1000)
                {
                    p5 += 1;
                }
            }

            percentP1 = (p1 / n) * 100;
            percentP2 = (p2 / n) * 100;
            percentP3 = (p3 / n) * 100;
            percentP4 = (p4 / n) * 100;
            percentP5 = (p5 / n) * 100;
            Console.WriteLine($"{percentP1:F2}%");
            Console.WriteLine($"{percentP2:F2}%");
            Console.WriteLine($"{percentP3:F2}%");
            Console.WriteLine($"{percentP4:F2}%");
            Console.WriteLine($"{percentP5:F2}%");
        }
    }
}
