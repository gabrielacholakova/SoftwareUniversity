using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double result = 1;

            for (int i = 0; i <= num; i+=2)
            {
                
                Console.WriteLine(result);
                result = result * 2 * 2;
            }
        }
    }
}
