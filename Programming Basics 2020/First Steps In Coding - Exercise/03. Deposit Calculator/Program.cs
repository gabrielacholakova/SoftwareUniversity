using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            double term = double.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double percent = (sum / 100) * interestRate;
            double percentForOneMonth = percent / 12;
            double totalSum = sum + (term * percentForOneMonth);

            Console.WriteLine(totalSum);

            
        }
    }
}
