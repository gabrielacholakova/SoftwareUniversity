using System;

namespace _03._Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i%2 == 1)
                {
                    oddSum += num;

                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }

                else if ( i % 2 == 0)
                {
                    evenSum += num;
                    if ( num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                
            }
            Console.WriteLine($"OddSum={oddSum:F2},");

            if(oddMin == oddMax * -1)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }
            if(oddMax == oddMin*-1)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            
           
            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (evenMin == evenMax * -1)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }
            if (evenMax == evenMin *-1)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            
            
        }
    }
}
