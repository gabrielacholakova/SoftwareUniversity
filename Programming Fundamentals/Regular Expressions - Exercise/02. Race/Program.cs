using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            string namePattern = @"[A-Za-z]";
            string kmPattern = @"\d";
            var dict = new Dictionary<string, int>();
            List<string> namesOfParticipants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int sum = 0;
            
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end of race")
                {
                    var mySortedList = dict.OrderByDescending(d => d.Value).Select(x=>x.Key).ToList();
                    
                    Console.WriteLine($"1st place: {mySortedList[0]}");
                    Console.WriteLine($"2nd place: {mySortedList[1]}");
                    Console.WriteLine($"3rd place: {mySortedList[2]}");
                    
                    break;
                }

                Regex nameRegex = new Regex(namePattern);
                var nameMatches = nameRegex.Matches(input);
                var name = String.Concat(nameMatches);

                Regex kmRegex = new Regex(kmPattern);
                var kmMatches = kmRegex.Matches(input);
                for (int i = 0; i < kmMatches.Count; i++)
                {
                    int num = (int.Parse)(kmMatches[i].Value);
                    sum += num;
                }

                if(namesOfParticipants.Contains(name))
                {
                    if(!dict.ContainsKey(name))
                    {
                        dict.Add(name,sum);
                    }
                    else
                    {
                       dict[name] += sum;
                    }
                }
                sum = 0;
            }

           
        }
    }
}
