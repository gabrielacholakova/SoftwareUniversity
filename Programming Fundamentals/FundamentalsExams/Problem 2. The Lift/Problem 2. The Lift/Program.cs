using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            List<int> peopleOnTheWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = 4;
            int eachWagon = 0;
            int leftPeople = 0;
            int totalLeftPeople = 0;
            int oneWagon = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < peopleOnTheWagons.Count; i++)
            {
                if (peopleOnTheWagons[i] < maxCapacity)
                {
                    
                    oneWagon = maxCapacity - peopleOnTheWagons[i];
                    eachWagon = oneWagon + peopleOnTheWagons[i];
                    totalLeftPeople = people - oneWagon;
                    
                    
                }
               
                if (people < maxCapacity)
                {
                    list.Add(people);
                }
                else
                {
                    list.Add(eachWagon);
                }
                people = totalLeftPeople;
            }
            if (people <= 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", list));
            }
           
        }
    }
}
