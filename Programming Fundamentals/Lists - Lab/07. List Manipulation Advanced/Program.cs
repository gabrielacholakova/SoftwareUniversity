using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<int> list = new List<int>();
            List<int> filterNum = new List<int>();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                list.Add(int.Parse(numbers[i]));
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
               
                if ( command[0] == "end")
                {
                    break;
                }
                

                if (command[0] == "Contains")
                {
                    if (numbers.Contains(command[1]))
                    {
                        Console.WriteLine("Yes");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                        continue;
                    }
  
                }
                if (command[0] == "PrintEven")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            Console.Write(string.Join(" ", list[i]) + " ");
                           
                        }
                    }
                    Console.WriteLine();
                }
                if (command[0] == "PrintOdd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i]%2==1)
                        {
                            Console.Write(string.Join(" ", list[i]) + " ");
                            continue;
                        }
                    }
                    Console.WriteLine();
                }
                if (command[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        sum += list[i];
                    }
                    Console.WriteLine(sum);
                    continue;
                }
                if (command[0] == "Filter")
                {
                    if (command[1] == ">")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            int number = int.Parse(command[2]);
                            if ( list[i] > number)
                            {
                                filterNum.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",filterNum));
                        filterNum.Clear();
                        continue;
                    }
                    if (command[1] == "<")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            int number = int.Parse(command[2]);
                            if (list[i] < number)
                            {
                                filterNum.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", filterNum));
                        filterNum.Clear();
                        continue;
                    }
                    if (command[1] == ">=")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            int number = int.Parse(command[2]);
                            if (list[i] >= number)
                            {
                                filterNum.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", filterNum));
                        filterNum.Clear();
                        continue;
                    }
                    if (command[1] == "<=")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            int number = int.Parse(command[2]);
                            if (list[i] <= number)
                            {
                                filterNum.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", filterNum));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
