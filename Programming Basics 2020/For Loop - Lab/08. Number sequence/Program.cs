using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number < min)
                {
                    min = number;
                }
                if (number  > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
