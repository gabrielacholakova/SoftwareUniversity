using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNums = 0;
            int evenNums = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNums += num;
                }
                else if (i%2==1)
                {
                    oddNums += num;
                }
                
            }
            if (evenNums > oddNums)
            {
                int diff = evenNums - oddNums;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
            else if (oddNums > evenNums)
            {
                int diff = oddNums - evenNums;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
            else if (oddNums == evenNums)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(evenNums)}");
            }

        }
    }
}
