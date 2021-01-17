using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<int> newList = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                newList.Add(int.Parse(input[i]));
            }

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "swap")
                {                                               
                    int firstIndex = int.Parse(command[1]);     
                    int secondIndex = int.Parse(command[2]);
                    int firstNum = int.Parse(input[firstIndex]);
                    int secondNum = int.Parse(input[secondIndex]);
                    int temp = newList[firstIndex];
                    newList[firstIndex] = newList[secondIndex];
                    newList[secondIndex] = temp;
                    
                }
                if (command[0] == "multiply")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    int firstNum = newList[firstIndex];
                    int secondNum = newList[secondIndex];
                    int result = firstNum * secondNum;
                    newList.Insert(firstIndex, result);
                    newList.RemoveAt(firstIndex + 1);

                }
                if(command[0] == "decrease")
                {
                    for (int i = 0; i < newList.Count; i++)
                    {
                        int num = newList[i];
                        newList.Insert(i,num-1 );
                        newList.RemoveAt(i + 1);
                    }
                }
            }

            Console.WriteLine(string.Join(',',newList));
        }
    }
}
