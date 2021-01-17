using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            double savedMoney = 0;

            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double vacationPrice = double.Parse(Console.ReadLine());
                

                while (savedMoney < vacationPrice)
                {
                    double input = double.Parse(Console.ReadLine());
                    savedMoney += input;

                }

                if (savedMoney >= vacationPrice)
                {
                    Console.WriteLine($"Going to {destination}!");
                    savedMoney = 0;
                }

            }
        }
    }
}
