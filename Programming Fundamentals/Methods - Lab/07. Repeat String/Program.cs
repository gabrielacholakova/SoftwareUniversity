using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Print(input, times);
        }

        static void Print (string input, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(input);
            }
        }
    }
}
