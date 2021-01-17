using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPleyer = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (true)
            { 
                if (firstPlayer.Count == 0 || secondPleyer.Count == 0)
                {
                    if (firstPlayer.Count != 0)
                    {
                        for (int i = 0; i < firstPlayer.Count; i++)
                        {
                            sum += firstPlayer[i];
                        }

                        Console.WriteLine($"First player wins! Sum: {sum}");
                        break;
                    }
                    else if (secondPleyer.Count != 0)
                    {
                        for (int i = 0; i < secondPleyer.Count; i++)
                        {
                            sum += secondPleyer[i];
                        }

                        Console.WriteLine($"Second player wins! Sum: {sum}");
                        break;
                    }

                   
                }
                if (firstPlayer[0] > secondPleyer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPleyer[0]);
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPleyer.Remove(secondPleyer[0]);
                }
                else if (secondPleyer [0] > firstPlayer[0])
                {
                    secondPleyer.Add(secondPleyer[0]);
                    secondPleyer.Add(firstPlayer[0]);
                    secondPleyer.Remove(secondPleyer[0]);
                    firstPlayer.Remove(firstPlayer[0]);
                }
                else if (secondPleyer[0] == firstPlayer[0])
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPleyer.Remove(secondPleyer[0]);
                }

            }
        }
    }
}
