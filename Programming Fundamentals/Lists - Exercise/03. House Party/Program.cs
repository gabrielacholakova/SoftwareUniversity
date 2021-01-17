using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            List<string> coming = new List<string>();


            for (int i = 0; i < countOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[2] == "going!")
                {
                    if (coming.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        coming.Add(command[0]);
                    }
                   
                }
                if (command[2] == "not")
                {
                    if (coming.Contains(command[0]))
                    {
                        coming.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < coming.Count; i++)
            {
                Console.WriteLine(coming[i]);
            }
            
            
            
        }
    }
}
