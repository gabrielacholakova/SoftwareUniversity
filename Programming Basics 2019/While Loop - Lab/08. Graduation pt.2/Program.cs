using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int expelled = 0;
            int classes  = 0;
            double totalGrades = 0;

            while (true)
            {
                double grade = double.Parse(Console.ReadLine());
                classes += 1;

                if (grade < 4)
                {
                    expelled += 1;

                    if (expelled == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {classes - 1} grade");
                        System.Environment.Exit(0);
                    }
                }

                totalGrades += grade;

                if (classes == 12)

                {
                    double averageGrade = totalGrades / 12;
                    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
                    System.Environment.Exit(0);
                }


            }
        }
    }
}
