using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "register")
                {
                    if(dict.ContainsKey(command[1])) //ако джон го има в списъка вече 
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                    else                            //ако джон го няма
                    {
                        dict.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }

                }
                if (command[0] == "unregister")
                {
                    if (dict.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} unregistered successfully");
                        dict.Remove(command[1]);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " => " + pair.Value);
            }
        }
    }
}
