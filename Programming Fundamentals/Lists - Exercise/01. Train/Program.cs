using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> passengers = Console.ReadLine().Split().ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < passengers.Count; i++)
            {
                list.Add(int.Parse(passengers[i]));
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                if (command[0] == "Add")
                {
                    
                    list.Add(int.Parse(command[1]));
                }
                else
                {
                    int morePassengers = int.Parse(command[0]);
                  
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        
                        int totalPassengers = morePassengers + list[i];

                        if ( totalPassengers <= maxCapacity)
                        {
                            
                            list.Insert(i,totalPassengers);
                            list.Remove(list[i+1]);

                            break;
                        }
                    }
                }
            }

        }
    }
}
