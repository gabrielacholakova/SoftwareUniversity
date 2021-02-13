using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            List<int> orders = Console.ReadLine().Split().Select(int.Parse).ToList();
            var queue = new Queue<int>();
            int leftFood = 0;
            

            for (int i = 0; i < orders.Count; i++)
            {
                queue.Enqueue(orders[i]);
            }
            int max = queue.Max();
            for (int i = queue.Count; i > 0; i--)
            {
                int currentOrder = queue.Dequeue();
               
                if (foodQuantity < currentOrder)
                {
                        Console.WriteLine(max);
                        Console.WriteLine($"Orders left: {string.Join(" ", currentOrder)}");
                        break;
                    
                }
                if (queue.Count == 0 && leftFood >= currentOrder)
                {
                    Console.WriteLine(max);
                    Console.WriteLine("Orders complete");
                    break;
                }


                leftFood = foodQuantity - currentOrder;
                    foodQuantity = leftFood;

             }
           

        }
    }
}
