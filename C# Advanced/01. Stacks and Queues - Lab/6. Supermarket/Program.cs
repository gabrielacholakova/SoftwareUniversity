using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
                if (name == "Paid")
                {
                    while (queue.Count>0)
                    {
                        Console.WriteLine(queue.Peek());
                        queue.Dequeue();
                    }
                    continue;
                }
                queue.Enqueue(name);
            }
        }
    }
}
