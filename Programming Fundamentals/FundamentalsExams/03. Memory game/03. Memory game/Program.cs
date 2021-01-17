using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceOfElements = Console.ReadLine().Split().ToList();
            int counter = 0;
            while (true)
            {
                List<string> elements = Console.ReadLine().Split().ToList();
                counter++;
                if (elements[0] == "end" && sequenceOfElements.Count > 0)
                {
                    Console.WriteLine($"Sorry you lose :(");
                    Console.WriteLine(string.Join(" ",sequenceOfElements));
                    break;
                }
                if (elements[0] == "end" &&  sequenceOfElements.Count == 0)
                {
                    break;
                }
                if (sequenceOfElements.Count == 0 && elements[0] == "end" )
                {
                    Console.WriteLine($"You have won in {counter -1} turns!");
                    break;
                }
                if (sequenceOfElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    continue;
                }

                int firstIndex = (int.Parse(elements[0]));
                int secondIndex = (int.Parse(elements[1]));
                if (firstIndex < 0 || secondIndex < 0)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    int middle = sequenceOfElements.Count / 2;
                    string moves = counter.ToString();
                    sequenceOfElements.Insert(middle, moves +"a");
                    sequenceOfElements.Insert(middle + 1, moves + "a");
                    
                    continue;
                }
                if (sequenceOfElements[firstIndex] != sequenceOfElements[secondIndex])
                {
                    Console.WriteLine("Try again!");
                    continue;
                }
                if (sequenceOfElements[firstIndex] == sequenceOfElements[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequenceOfElements[firstIndex]}!");
                    if (secondIndex > firstIndex)
                    {
                        sequenceOfElements.RemoveAt(secondIndex);
                        sequenceOfElements.RemoveAt(firstIndex);
                    }
                    else
                    {
                        sequenceOfElements.RemoveAt(firstIndex);
                        sequenceOfElements.RemoveAt(secondIndex);
                    }
                    
                }
                
            }
        }
    }
}
