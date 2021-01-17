using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split().ToList();
            List<int> numbers = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                numbers.Add(int.Parse(sequence[i]));
            }
            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();
                if (commands[0] == "End")
                {
                    Console.WriteLine(string.Join("|",numbers));
                    break;
                }

                if (commands[0] == "Shoot")
                {
                    int index = int.Parse(commands[1]); 
                    int power = int.Parse(commands[2]);
                    if(index > numbers.Count)
                    {
                        continue;
                    }
                    int num = numbers[index] - power;
                    numbers.RemoveAt(index);
                    numbers.Insert(index, num);
                    if (num <= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                }
                if(commands[0] == "Add")
                {
                    int index = int.Parse(commands[1]);
                    int value = int.Parse(commands[2]);
                    if (index > numbers.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    else
                    {
                        numbers.Insert(index,value);
                    }
                }
                if(commands[0] == "Strike")
                {
                    int index = int.Parse(commands[1]);
                    int radius = int.Parse(commands[2]);

                    if (index > radius)
                    {
                        numbers.RemoveAt(index);
                        for (int i = 0; i < index; i++)
                        {
                            numbers.RemoveAt(index - radius);
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }

                }
            }

        }
    }
}
