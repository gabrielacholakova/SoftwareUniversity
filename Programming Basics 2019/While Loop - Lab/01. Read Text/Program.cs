using System;

namespace While_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string words = Console.ReadLine();

                if (words == "Stop")
                {
                    break;
                }
                Console.WriteLine(words);
            }
         
        }
    }
}
