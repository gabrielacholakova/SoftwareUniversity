using System;
using System.Collections;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var queue = new Queue();
            int count = 0;
            while (true)
            {
                string cars = Console.ReadLine();
                if ( cars == "end")
                {
                    Console.WriteLine($"{count} cars passed the crossroads.");
                    break;
                }
                if (cars == "green")
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (queue.Count ==0 )
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                    
                }
                else
                {
                    queue.Enqueue(cars);
                }
                
            }
        }
    }
}
