using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();//3
            double badGrades = 0;
            double totalGrades = 0;
            double averageScore = 0;
            double count = 0;
            string name2 = ""; 
            

            while (name!="Enough")
            {
               
                double grades = double.Parse(Console.ReadLine());
                
                if (name != "Enough")
                {
                    name2 = name;
                }


                if (grades <= 4)
                {
                    badGrades += 1;
                    if (badGrades == input)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        System.Environment.Exit(0);
                    }
                }
                

                 totalGrades += grades;
                
                count += 1;
                name = Console.ReadLine();

            }

            averageScore = totalGrades / count;
            Console.WriteLine($"Average score: {averageScore:F2}");
            Console.WriteLine($"Number of problems: {count}");
            Console.WriteLine($"Last problem: {name2}");
            System.Environment.Exit(0);
        }
    }
}
