using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfPeople = double.Parse(Console.ReadLine());
            double totalGrades = 0;
            double counter = 0;
            double averageGrades = 0;
            double allGrades = 0;
            double allAverageGrades = 0;
            double counterForAllGrades = 0;



            while (true)
            {
                string nameOfPresentation = Console.ReadLine();

                if(nameOfPresentation == "Finish")
                {
                    allAverageGrades = allGrades / counterForAllGrades;
                    Console.WriteLine($"Student's final assessment is {allAverageGrades:F2}.");
                    break;
                }

                for (int i = 0; i < countOfPeople; i++)
                {
                    counterForAllGrades++;
                    counter++;
                    double grades = double.Parse(Console.ReadLine());
                    totalGrades += grades;
                    allGrades += grades;

                    if (counter == countOfPeople)
                    {
                        averageGrades = totalGrades / countOfPeople;
                        totalGrades = 0;
                        counter = 0;
                        Console.WriteLine($"{nameOfPresentation} - {averageGrades:F2}.");
                    }

                }
            }
            
        }
    }
}
