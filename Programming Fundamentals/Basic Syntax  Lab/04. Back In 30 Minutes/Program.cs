using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            DateTime currentTime = new DateTime();
            currentTime = currentTime.AddHours(hours);
            currentTime = currentTime.AddMinutes(minutes);

            currentTime = currentTime.AddMinutes(30);

            Console.WriteLine($"{currentTime.Hour}:{currentTime.Minute:D2}");
        }
    }
}