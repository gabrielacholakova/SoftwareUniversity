using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            List<int> list = new List<int>();

            int bomb = input[0]; //4
            int power = input[1]; //2
            int bombIndex = numbers.IndexOf(bomb);
            int totalSum = 0;
            while (bombIndex != -1)
            {
                int leftNumbers = bombIndex - power;
                int rightNumbers = bombIndex + power;
                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }
                if (rightNumbers > numbers.Count - 1)
                {
                    rightNumbers = numbers.Count - 1;
                }
               numbers.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);
                bombIndex = numbers.IndexOf(bomb);
            }
            
            for (int i = 0; i < numbers.Count; i++)
            {
                totalSum += numbers[i];
            }
            Console.WriteLine(totalSum);
            




        }
    }
}
