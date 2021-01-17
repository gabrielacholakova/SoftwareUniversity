using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            
            if (leftSum > rightSum)
            {
                int diff = leftSum - rightSum;
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");
            }
            else if(rightSum > leftSum)
            {
                int diff = rightSum - leftSum;
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");
            }
            else
            {
                Console.WriteLine($"Yes, sum = {Math.Abs(leftSum)}");
            }

        }
    }
}
