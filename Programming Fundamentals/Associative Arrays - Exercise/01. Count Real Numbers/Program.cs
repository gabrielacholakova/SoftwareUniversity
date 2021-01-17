using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            
            var dict = new Dictionary<char, int>();
            
            int quantity = 1;
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol == ' ')
                {
                    continue;
                }
                if (dict.ContainsKey(symbol))
                {
                    dict[symbol]++;
                }
                else
                {
                    dict.Add(symbol, 1);
                }
                     
            }
            
            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
