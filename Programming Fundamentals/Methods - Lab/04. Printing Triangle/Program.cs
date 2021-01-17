using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            One(n);
            Two(n);
        }
        static void FirstHalf (int start , int end )
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                
            }
            Console.WriteLine();
        }
        static void One (int n )
        {
            for (int i = 1; i <= n; i++)
            {
                FirstHalf(1, i);
            }
        }
        static void Two (int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                FirstHalf(1, i);
            }
        }
    }
}
