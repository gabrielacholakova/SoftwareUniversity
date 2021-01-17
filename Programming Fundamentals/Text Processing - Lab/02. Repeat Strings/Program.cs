using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        public static object StringBilder { get; private set; }

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            foreach (var item in words)
            {
                int count = item.Length;

                for (int i = 0; i < count; i++)
                {
                    result.Append(item);
                }
            }
            Console.WriteLine(result);
        }
    }
}
