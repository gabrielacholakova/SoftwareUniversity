using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        public static object GetRemainingElements { get; private set; }

        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newList = new List<int>(firstList.Count);

            if (firstList.Count > secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    newList.Add(firstList[i]);
                    newList.Add(secondList[i]);
                    firstList[i] = 0;
                }
                firstList.RemoveAll(i => i == 0);
                for (int i = 0; i < firstList.Count; i++)
                {
                    newList.Add(firstList[i]);
                }
            }
            else if (firstList.Count < secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    newList.Add(firstList[i]);
                    newList.Add(secondList[i]);
                    secondList[i] = 0;
                }
                secondList.RemoveAll(i => i == 0);
                for (int i = 0; i < secondList.Count; i++)
                {
                    newList.Add(secondList[i]);
                }
            }
            else if (firstList.Count == secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    newList.Add(firstList[i]);
                    newList.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", newList)); 
            
            

               
            
          
        }
    }
}
