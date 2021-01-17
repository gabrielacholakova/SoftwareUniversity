using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, List<string>>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split("->").ToList();
                if (input[0] == "End")
                {
                    break;
                }
                if(!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], new List<string>());
                    dict[input[0]].Add(input[1]);
                }
                else
                {
                    
                    if (!dict[input[0]].Contains(input[1]))
                    {
                        dict[input[0]].Add(input[1]);
                    }
                    
                }
            }

            foreach (var pair in dict)
            {
                List<string> final = pair.Value;
                Console.WriteLine(pair.Key);
                foreach (var id in final)
                {
                    Console.WriteLine("--" + id);
                }
                
            }


        }
    }
}
