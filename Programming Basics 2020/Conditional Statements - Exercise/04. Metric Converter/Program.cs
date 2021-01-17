using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double sum = 0.0;

            if (input == "m")
            {
                if (output == "cm")
                {
                    sum = number * 100;
                }
                else if (output == "mm")
                {
                    sum = number * 1000;
                }

                Console.WriteLine($"{sum:F3}");
            }
            else if ( input == "cm")
            {
                if (output == "m")
                {
                    sum = number / 100;
                }
                else if (output == "mm")
                {
                    sum = number * 10;
                }
                Console.WriteLine($"{sum:F3}");
            }
            else if ( input == "mm")

            {
                if (output == "cm")
                {
                    sum = number * 0.1;
                }
                else if (output == "m")
                {
                    sum = number * 0.001;
                }
                Console.WriteLine($"{sum:F3}");
            }

        }
    }
}
