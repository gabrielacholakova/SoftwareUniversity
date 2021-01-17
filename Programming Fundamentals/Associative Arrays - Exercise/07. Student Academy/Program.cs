using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                    dict[name].Add(grade);
                }
                else
                {
                    dict[name].Add(grade);
                }
            }

            var averageResults = new Dictionary<string, double>();

            foreach (var pair in dict)
            {
                averageResults.Add(pair.Key, pair.Value.Average());
            }
            foreach (var pair in averageResults.Where(x=>x.Value >= 4.50).OrderByDescending(st => st.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
    }
}
