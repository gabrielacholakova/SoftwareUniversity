using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            switch (input)
            {
                case "*":
                    Console.WriteLine(Multiplication(firstNum, secondNum));
                    break;
                case "/":
                    Console.WriteLine(Division(firstNum,secondNum));
                    break;
                case "+":
                    Console.WriteLine(Addition(firstNum, secondNum));
                    break;
                case "-":
                    Console.WriteLine(Subtraction(firstNum,secondNum));
                    break;
                    
            }

        }
        static double Multiplication (double firstNum, double secondNum)
        {
            double sum = firstNum * secondNum;
            return sum;
        }
        static double Division ( double firstNum, double secondNum)
        {
            double sum = firstNum / secondNum;
            return sum;
        }
        static double Addition (double firstNum, double secondNum)
        {
            double sum = firstNum + secondNum;
            return sum;
        }
        static double Subtraction (double firstNum, double secondNum)
        {
            double sum = firstNum - secondNum;
            return sum;
        }
    }
}
