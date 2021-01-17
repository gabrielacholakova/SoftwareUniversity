using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach  (string word in words)
            {
                string wordsToLower = word.ToLower();
                if (counts.ContainsKey(wordsToLower))
                {
                    counts[wordsToLower]++;
                }
                else
                {
                    counts.Add(wordsToLower, 1);
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 ==1)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }

     
    }
}
