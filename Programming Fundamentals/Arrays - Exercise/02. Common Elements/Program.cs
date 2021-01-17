using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ').ToArray();
            string[] secondLine = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < firstLine.Length; i++)
            {
                string element = firstLine[i];

                for (int k = 0; k < secondLine.Length; k++)
                {
                    string secondElement = secondLine[k];

                    if (element == secondElement)
                    {
                        Console.Write(element + " ");
                    }
                }


            }
        }
    }
}
