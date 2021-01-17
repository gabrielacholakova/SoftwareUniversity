using System;

namespace _05._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());

            int hoursNeeded = countOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {hoursNeeded} hours to complete {countOfProjects} project/s.");
        }
    }
}
