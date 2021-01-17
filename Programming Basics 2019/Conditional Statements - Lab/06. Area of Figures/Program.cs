﻿using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());

            if(type == "square")
            {
                double area = a * a;
                Console.WriteLine($"{area:F3}");
            }
            else if (type == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine($"{area:F3}");
            }
            else if (type == "circle")
            {
                double area = Math.PI * a * a;
                Console.WriteLine($"{area:F3}");
            }
            else if (type == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double area = (a * b) / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
