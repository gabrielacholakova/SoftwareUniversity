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
            var queue = new Queue<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count() == 0)
                {
                    Console.WriteLine("0");
                }

                else
                {
                    int minNum = queue.Min();
                    Console.WriteLine(minNum);
                }
            }
        }
    }
}
