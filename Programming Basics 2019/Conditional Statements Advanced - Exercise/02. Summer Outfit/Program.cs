using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (time == "Morning")
            {
                if (degrees >= 10 && degrees <=18 )
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (degrees >= 25)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
            }
            else if ( time == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (degrees >= 25)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                }
            }
            else if (time == "Evening")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (degrees >= 25)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }



        }
    }
}
