using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rackCapacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(sequence);

            int rackCounter = 1;
            int sum = 0;

            while (stack.Count > 0)
            {
                var current = stack.Peek();

                if (sum+current > rackCapacity)
                {
                    rackCounter++;
                    sum = 0;
                }
                else
                {
                    sum += stack.Pop();
                }
            }
            Console.WriteLine(rackCounter);
            
        }
    }
}
