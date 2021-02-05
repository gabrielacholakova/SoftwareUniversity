using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(arr);

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if(command[0].ToLower() == "end")
                {
                    break;
                }
                if (command[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                if (command[0].ToLower() == "remove")
                {
                    int count = int.Parse(command[1]);
                    if(count > stack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }

            }
            int sum = 0;
            while (stack.Count != 0)
            {
                sum += stack.Pop();
            }
           
              Console.WriteLine($"Sum: {sum}");
            
            
        }

    }
}
