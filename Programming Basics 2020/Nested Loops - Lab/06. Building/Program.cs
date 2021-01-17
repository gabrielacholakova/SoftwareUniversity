using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine()); 
            int rooms = int.Parse(Console.ReadLine()); 
          

            for (int i = 0; i < rooms; i++)
            {
                Console.Write($"L{floors}{i}");
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            for (int i = floors-1; i > 0; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j}");
                        Console.Write(" ");
                    }
                    
                    else if (i % 2 == 1)
                    {
                        Console.Write($"A{i}{j}");
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
