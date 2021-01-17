using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            double final = 0.0;
            
            
            if ( minutes > 45)
            {    
                if ( hour == 23)
                {
                    hour = 0 - 1;
                }
                hour = hour + 1;
                minutes = minutes + 15;
                final =  minutes - 60;
                if (final < 10 && hour < 23)
                {
                    Console.WriteLine($"{hour}:0{final}");
                }
                else if( final >= 10 && hour < 23)
                {
                    Console.WriteLine($"{hour}:{final}");
                }
               

            }
            else if ( minutes == 45)
            {
                if (hour == 23)
                {
                    Console.WriteLine("0:00");
                }

                else if (hour != 23)

                {
                    hour = hour + 1;
                    Console.WriteLine($"{hour}:00");
                }
            }


           else if (minutes < 45)
            {
                minutes = minutes + 15;
                Console.WriteLine($"{hour}:{minutes}");
            }

            
        }
    }
}
