using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                list.Add(int.Parse(numbers[i]));
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if(command[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if ( index >=0 && index < list.Count)
                    {
                        list.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                    
                }
                if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                    else 
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i <count ; i++)
                    {
                       
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                if (command[1] == "right")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int lastNum = list[list.Count - 1];
                        list.Insert(0,lastNum);
                        list.RemoveAt(list.Count - 1);
                    }
                }
            }
        }
    }
}
