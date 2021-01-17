using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleLetter(input);
            //sometext12 -te
        }
        static string MiddleLetter(string input)
        {
            string[] arr = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = input[i].ToString();
            }

            for (int i = 0; i <= arr.Length/2; i++)
            {
                if(arr.Length % 2 != 0)
                {
                    int middle = arr.Length / 2;
                    if (i == middle)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                else if (arr.Length % 2 == 0)
                {
                    int middle = arr.Length / 2;
                    if (i == middle)
                    {
                        Console.WriteLine(arr[i-1] + arr[i]);
                    }
                }
                
            }
            
            return input;
        }
    }
}
