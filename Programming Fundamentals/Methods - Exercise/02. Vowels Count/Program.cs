using System;
using System.Linq;

namespace _02._Vowels_Count
{
    public static class StringExtensions
    {
        public static string[] ToStringArray(this string text)
        {
            string[] arr = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i].ToString();
            }

            return arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            text.ToLower();
            Console.WriteLine(VowelsCount(text));
            
        }

        static string VowelsCount(string text)
        {
            int sum = 0;
      
            string[] array = text.ToStringArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (array[i] == "a")
                {
                    sum ++;
                }
                else if (array[i] == "e")
                {
                    sum++;
                }
                else if (array[i] == "o")
                {
                    sum++;
                }
                else if (array[i] == "u")
                {
                    sum++;
                }
                else if (array[i] == "i")
                {
                    sum++;
                }
            }

            return sum.ToString();
        }
    }
}
