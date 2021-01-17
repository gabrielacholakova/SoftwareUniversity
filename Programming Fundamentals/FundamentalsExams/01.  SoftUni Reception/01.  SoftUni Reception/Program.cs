using System;

namespace _01.__SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            double attendedStudentsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            double totalHours = studentsCount / attendedStudentsPerHour;
            double breakHours = totalHours / 3;
            double total = totalHours + breakHours;

            Console.WriteLine(Math.Round(total));
        }
    }
}
