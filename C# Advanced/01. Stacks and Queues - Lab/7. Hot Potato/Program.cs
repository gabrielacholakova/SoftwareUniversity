using System;
using System.Collections;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kidsNames = Console.ReadLine().Split(" ");
            int countOfToss = int.Parse(Console.ReadLine());

            var queue = new Queue();

            for (int i = 0; i < kidsNames.Length; i++)
            {
                queue.Enqueue(kidsNames[i]);
            }

            while (queue.Count > 1)
            {
                for (int i = 1; i < countOfToss; i++)
                {
                    
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
