using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minSalary * 0.35);
            double excellentGrade = Math.Floor(grade * 25);

            if (income <= minSalary && grade >= 4.5 )
            {
                if (grade >= 5.5)
                {
                    if (socialScholarship > excellentGrade)
                    {
                        Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                    }
                    else if (excellentGrade > socialScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {excellentGrade} BGN");
                    }
                    else if ( excellentGrade == socialScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {excellentGrade} BGN");
                    }
                }
                else if ( grade <= 5.5 && grade >= 4.5)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                
            }

            else if(income >= minSalary)
            {
                if (grade >= 5.5)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentGrade} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            

            

        }
    }
}
