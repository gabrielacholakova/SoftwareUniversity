using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();
               
                if(commands[0] == 1 )
                { 
                    
                    stack.Push(commands[1]);
                }
                if(commands[0] == 2)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    stack.Pop();
                }
                if (commands[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        int max = stack.Max();
                        Console.WriteLine(max);
                    }
                   
                }
                if (commands[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        int min = stack.Min();
                        Console.WriteLine(min);
                    }
                    
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
