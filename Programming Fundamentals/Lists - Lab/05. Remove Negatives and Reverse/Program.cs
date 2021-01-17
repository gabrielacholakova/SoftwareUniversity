using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list = new List<int>();
            List<int> negatveNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    list.Add(numbers[i]);
                }
                if (numbers[i] < 0)
                {
                    negatveNumbers.Add(numbers[i]);
                }
              
            }
            if (negatveNumbers.Count == numbers.Count)
            {
                Console.WriteLine("empty");
            }
            else
            {
                list.Reverse();
                Console.WriteLine(string.Join(" ", list));
            }
            
        }
    }
}
