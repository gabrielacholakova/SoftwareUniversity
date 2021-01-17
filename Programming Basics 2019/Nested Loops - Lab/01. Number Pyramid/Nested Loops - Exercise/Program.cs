using System;

namespace Nested_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //10
            int current = 1;
            bool flag = false;
            for (int i = 1; i <= n; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                   if (current > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
