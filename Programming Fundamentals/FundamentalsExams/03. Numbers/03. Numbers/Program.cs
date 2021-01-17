using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> sequence = Console.ReadLine().Split().Select(double.Parse).ToList();
            double sum = 0;
            int counter = 0;
            List<double> list = new List<double>();
            List<double> finalList = new List<double>();
            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }
            double averageSum = sum / sequence.Count;
           
            
            for (int i = 0; i < sequence.Count; i++)
            {
               
                if (sequence[i] > averageSum)
                {
                    list.Add(sequence[i]);
                }
            }
                var max = list.OrderByDescending(i => i).ToList();
            if (max.Count < 5)
            {
                Console.WriteLine(string.Join(" ",max));
            }
            if (max.Count > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    finalList.Add(max[i]);
                }
                Console.WriteLine(string.Join(" ", finalList));
            }
            else
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
