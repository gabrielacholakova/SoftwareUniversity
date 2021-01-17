using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfStudents = double.Parse(Console.ReadLine());
            double countOfLectures = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            List<double> studentsAttendances = new List<double>();

            for (int i = 0; i < countOfStudents; i++)
            {
                double commands = double.Parse(Console.ReadLine());
                studentsAttendances.Add(commands);
            }
            studentsAttendances.Sort();
            double bestStudent = studentsAttendances[studentsAttendances.Count - 1];
            double totalBonus = (bestStudent / countOfLectures) * (5 + initialBonus);

            Console.WriteLine($"Max bonus: {Math.Round(totalBonus)}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
          
            
        }
    }
}
