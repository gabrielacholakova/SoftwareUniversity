using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string line = Console.ReadLine();

            int index = line.IndexOf(word);
            while (index != -1)
            {
                line = line.Remove(index, word.Length);
                index = line.IndexOf(word);
            }
            Console.WriteLine(line);
        }
    }
}
