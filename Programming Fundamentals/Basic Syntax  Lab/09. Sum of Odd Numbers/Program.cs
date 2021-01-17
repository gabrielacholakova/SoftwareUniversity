using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= num*2; i++)
            {
                
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.WriteLine(i);
                    
                }
                if(i == num * 2)
                {
                    Console.WriteLine($"Sum: {sum}");
                }
            }
        }
    }
}
