using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<string> list = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                list.Add(numbers[i]);
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Add")
                {
                    list.Add(command[1]);
                }
                if (command[0] == "Remove")
                {
                    list.Remove(command[1]);
                }
                if (command[0] == "RemoveAt")
                {
                   int remove = int.Parse(command[1]);
                    list.RemoveAt(remove);
                }
                if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    list.Insert(index, command[1]);
                }
                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
            }
        }
    }
}
