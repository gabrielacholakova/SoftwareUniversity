using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = 0;
            switch (command)
            {
                case "add":
                    Add(a,b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
            }
        }

        static void Add(double a,double b)
        {
            
            double result = a + b;
            Console.WriteLine(result);
        }
        static void Multiply (double a, double b)
        {
            Console.WriteLine(a*b);
        }
        static void Subtract (double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}
