using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = new string[n];
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine().Split(' ').ToArray(); //1,5

                if ( i%2 == 0)
                {
                    firstArr[i] = numbers[0];
                    secondArr[i] = numbers[1];
                }
                else if(i%2 == 1)
                {
                    firstArr[i] = numbers[1];
                    secondArr[i] = numbers[0];
                }

                
            }
            Console.WriteLine(string.Join(" " , firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
