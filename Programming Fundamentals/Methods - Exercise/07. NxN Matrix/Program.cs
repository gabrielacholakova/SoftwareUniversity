using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        private static object matrix;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static int Matrix (int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                
                for (int k = 0; k < n; k++)
                {
                    Console.Write(n + " ");
                    
                }
                Console.WriteLine();
            }


            return n;
        }
    }
}
