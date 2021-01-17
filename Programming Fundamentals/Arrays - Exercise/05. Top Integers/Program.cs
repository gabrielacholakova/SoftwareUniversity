using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < nums.Length; i++)
            {
                int numbers = nums[i];

                for (int k = i + 1; k < nums.Length; k++)
                {
                    int secondNumber = nums[k];

                    if (numbers <= secondNumber)
                    {
                        break;
                    }
                    else if (k == nums.Length - 1)
                    {
                        Console.Write(numbers + " ");
                    }
                }
            }
            Console.WriteLine(nums[nums.Length - 1]);
        }
    }
}
