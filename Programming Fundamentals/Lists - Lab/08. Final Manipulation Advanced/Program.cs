using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Final_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<int> intList = new List<int>();
            List<int> filter = new List<int>();
            List<int> evenOrOdds = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                intList.Add(int.Parse(numbers[i]));
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "end")
                {
                   
                    break;
                }
                if (command[0] == "Add")
                {
                    numbers.Add(command[1]);
                }
                if (command[0] == "Remove")
                {
                    numbers.Remove(command[1]);
                }
                if (command[0] == "RemoveAt")
                {
                    int remove = int.Parse(command[1]);
                    intList.RemoveAt(remove);
                }
                if (command[0] == "Insert")
                {
                    numbers.Insert(intList[1], command[2]);
                }
                if (command[0] == "Contains")
                {
                   if ( numbers.Contains(command[1]))
                   {
                        Console.WriteLine("Yes");
                   }
                   else
                   {
                        Console.WriteLine("No such number");
                   }
                }
                if (command[0] == "PrintEven")
                {
                    for (int i = 0; i < intList.Count; i++)
                    {
                        if (intList[i] % 2 == 0)
                        {
                            evenOrOdds.Add(intList[i]);
                           
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenOrOdds));
                    evenOrOdds.Clear();
                }
                if (command[0] == "PrintOdd")
                {
                    for (int i = 0; i < intList.Count; i++)
                    {
                        if (intList[i] %2  == 1)
                        {
                            evenOrOdds.Add(intList[i]);
                            
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenOrOdds));
                    evenOrOdds.Clear();
                }
                if (command[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < intList.Count; i++)
                    {
                        sum += intList[i];
                    }

                    Console.WriteLine(sum);
                }
                if(command[0] == "Filter")
                {
                    if(command[1] == "<")
                    {
                        int number = int.Parse(command[2]);
                        for (int i = 0; i < intList.Count; i++)
                        {
                            if (intList[i] < number)
                            {
                                filter.Add(intList[i]);
                            }
                        }
                        
                        Console.WriteLine(string.Join(" ", filter));
                       
                        filter.Clear();
                    }
                    if (command[1] == ">")
                    {
                        int number = int.Parse(command[2]);
                        for (int i = 0; i < intList.Count; i++)
                        {
                            if (intList[i] > number)
                            {
                                filter.Add(intList[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", filter));
                        
                        filter.Clear();
                    }
                    if (command[1] == "<=")
                    {
                        int number = int.Parse(command[2]);
                        for (int i = 0; i < intList.Count; i++)
                        {
                            if (intList[i] <= number)
                            {
                                filter.Add(intList[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", filter));
                        
                        filter.Clear();
                    }
                    if (command[1] == ">=")
                    {
                        int number = int.Parse(command[2]);
                        for (int i = 0; i < intList.Count; i++)
                        {
                            if (intList[i] >= number)
                            {
                                filter.Add(intList[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", filter));

                        filter.Clear();
                        
                    }

                }
            }
        }
    }
}
