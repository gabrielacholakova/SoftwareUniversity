using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());

            int hoursNeeded = numOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {hoursNeeded} hours to complete {numOfProjects} project/s.");
        }
    }
}
