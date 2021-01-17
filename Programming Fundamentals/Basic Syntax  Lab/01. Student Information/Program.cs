using System;

namespace Basic_Syntax__Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:F2}");


        }
    }
}
