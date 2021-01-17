using System;

namespace Data_Types_and_Variables___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int firstSum = first + second;
            int secondSum = firstSum / third;
            int totalSum = secondSum * fourth;
            Console.WriteLine(totalSum);
        }
    }
}
