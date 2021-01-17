using System;
using System.Linq;
namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //0.9 1.5 2.4 2.5 3.14
            //0.9 => 1
            double[] numbers = Console.ReadLine()
                           .Split(' ')
                           .Select(double.Parse)
                           .ToArray();

            double[] emptyCollection = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                double element = numbers[i];
                emptyCollection[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(numbers[i] + " => " + emptyCollection[i]);
            }

        }
    }
}
