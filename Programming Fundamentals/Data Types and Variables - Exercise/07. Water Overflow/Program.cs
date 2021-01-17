using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int litersInTheTank = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                capacity -= liters;

                if (capacity < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity += liters;
                    

                }
                else if (capacity >= 0)
                {
                    
                    litersInTheTank += liters;
                }
               
            }

            Console.WriteLine(litersInTheTank);
        }
    }
}
