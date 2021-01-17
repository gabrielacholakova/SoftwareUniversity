using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = times; i <= 10; i++)
            {
               
                result = num * i;
                Console.WriteLine($"{num} X {i} = {result}");
                
            }
            if (times > 10)
            {
                result = num * times;
                Console.WriteLine($"{num} X {times} = {result}");

            }
        }
    }
}
