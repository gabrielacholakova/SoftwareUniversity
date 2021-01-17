using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourStart = int.Parse(Console.ReadLine());
            int minuteStart = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());
            int hour = 0;
            int minutes = 0;
            int difference = 0;

            minuteStart += hourStart * 60;
            minuteArrive += hourArrive * 60;
           
            if (minuteStart < minuteArrive)
            {
                
                Console.WriteLine("Late");
                difference = minuteArrive - minuteStart;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                    return;
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                    return;
                }
                
            }
            if (minuteArrive < minuteStart - 30)
            {
                Console.WriteLine("Early");
                difference = minuteStart - minuteArrive;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                    return;
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    if (minutes == 0)
                    {
                        Console.WriteLine($"{hour}:0{minutes} hours before the start");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                        return;
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = minuteStart - minuteArrive;
                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                
            }
            



        }
    }
}
