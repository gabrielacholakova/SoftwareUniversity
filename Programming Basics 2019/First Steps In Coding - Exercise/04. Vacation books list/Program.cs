using System;

namespace Co04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            double bookPages = double.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            double daysNeeded = double.Parse(Console.ReadLine());

            double timeForWholeBook = bookPages / pagesPerHour;
            double countOfHours = timeForWholeBook / daysNeeded;

            Console.WriteLine(countOfHours);

        }
    }
}
