using System;

namespace _9._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());
            double saturdayGames = 0;
            double sofiaWeekends = 0;
            double sofiaGames = 0;
            double allGames = 0;
            double totalGames = 0;

            sofiaWeekends = 48 - weekends;
            saturdayGames = (sofiaWeekends * 3) / 4;
            sofiaGames = (holidays * 2) / 3;
            allGames = saturdayGames + weekends + sofiaGames;

            if (typeOfYear == "leap")
            {
                double moreGames = (allGames / 100) * 15;
                totalGames = Math.Floor( moreGames + allGames);
                Console.WriteLine(totalGames);
            }
            else
            {
                Console.WriteLine(Math.Floor(allGames));
            }

            


        }
    }
}
