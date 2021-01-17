using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
              num = Math.Abs(num);
            int totalSum = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            Console.WriteLine(totalSum);
        }

        static int GetSumOfEvenDigits(int num)
        {
            string n = num.ToString();
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                int currentDigit = int.Parse(n[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(int num)
        {
            string n = num.ToString();
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                int currentDigit = int.Parse(n[i].ToString());
                if (currentDigit % 2 == 1)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
