using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count() == 0)
                {
                    Console.WriteLine("0");
                }

                else
                {
                    int minNum = stack.Min();
                    Console.WriteLine(minNum);
                }
            }
        }
    }
}
