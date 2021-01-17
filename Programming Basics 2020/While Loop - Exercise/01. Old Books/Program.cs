using System;

namespace While_Loop___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string theBook = Console.ReadLine();
            int count = 0;
            while (theBook != "No More Books")
            {
                string otherBooks = Console.ReadLine();
                count += 1;

                if (otherBooks == theBook)
                {
                    Console.WriteLine($"You checked {count -1} books and found it.");
                    System.Environment.Exit(0);
                }

                if (otherBooks == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count-1} books.");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
