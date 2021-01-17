using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine($"{num} X {i} = {result}");
            }
        }
    }
}
