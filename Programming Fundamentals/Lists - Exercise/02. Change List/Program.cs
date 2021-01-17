using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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

                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        list.Remove(number);
                    }
                    
                }
                if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    list.Insert(index, number);
                }
                if(command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                
            }
        }
    }
}
