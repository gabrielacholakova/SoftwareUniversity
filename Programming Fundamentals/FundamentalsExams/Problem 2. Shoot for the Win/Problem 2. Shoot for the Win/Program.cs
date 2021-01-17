using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<int> sequence = new List<int>();
            List <int> counter = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                sequence.Add(int.Parse(input[i]));  //24 50 36 70
            }
            while (true)
            {
                string number = Console.ReadLine();
                
                
                if (number == "End")
                {
                    break;
                }
                int index = int.Parse(number); //0
                if (index >= sequence.Count)
                {
                    continue;
                }
                else
                {
                    counter.Add(index);
                }
                int target = sequence[index]; //24
                sequence[index] = -1;
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == -1)
                    {
                        continue;
                    }
                    if (sequence[i] > target)
                    {
                        sequence.Insert(i, sequence[i] - target);
                        sequence.RemoveAt(i+1);
                        sequence[index] = -1;                  
                    }
                    else if(sequence[i] <= target)
                    {
                        sequence.Insert(i, sequence[i] + target);
                        sequence.RemoveAt(i+1);
                        sequence[index] = -1;
                    }
                }


            }

            Console.WriteLine($"Shot targets: {counter.Count} -> {string.Join(" ",sequence)}");
            
        }
    }
}
