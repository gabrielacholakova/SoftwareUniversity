using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfSongs = Console.ReadLine().Split(", ").ToList();
            var queue = new Queue<string>(listOfSongs);

            while (queue.Count>0)
            {
                string command = Console.ReadLine();

                
                if (command.Contains("Play"))
                {
                    
                    queue.Dequeue();
                }
                if (command.Contains("Add"))
                {
                    var wantedSong = command.Split("Add ");

                    if (!queue.Contains(wantedSong[1]))
                    {
                        queue.Enqueue(wantedSong[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{wantedSong[1]} is already contained!");
                    }
                }
                if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
