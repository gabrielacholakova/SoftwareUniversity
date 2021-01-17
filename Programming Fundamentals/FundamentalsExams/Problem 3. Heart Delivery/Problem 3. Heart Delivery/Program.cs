using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> neighborhood = Console.ReadLine().Split('@').ToList();
            List<int> houses = new List<int>();
            int jump = 0;
            int decreaseNum = 0;
            for (int i = 0; i < neighborhood.Count; i++)
            {
                houses.Add(int.Parse(neighborhood[i])); //2,4,2
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "Love!")
                {
                    Console.WriteLine($"Cupid's last position was {jump}.");
                    
                    break;
                }
                int index = int.Parse(command[1]); //jump 2
                
                jump += index;
                if (jump >= houses.Count)
                {
                    jump = 0;
                  
                }
                if (houses[jump] == 0)
                {
                    Console.WriteLine($"Place {houses[jump]} already had Valentine's day.");
                    continue;
                }
                decreaseNum = houses[jump] - 2;
                houses.Insert(jump, decreaseNum);
                houses.RemoveAt(jump + 1);

                if (decreaseNum == 0 || decreaseNum < 0)
                {
                    if (decreaseNum < 0)
                    {
                        jump = 0;
                        Console.WriteLine($"Place {jump} has Valentine's day.");
                    }
                    else
                    {
                        Console.WriteLine($"Place {jump} has Valentine's day.");
                    }
                    
                }

            }
        }
    }
}
