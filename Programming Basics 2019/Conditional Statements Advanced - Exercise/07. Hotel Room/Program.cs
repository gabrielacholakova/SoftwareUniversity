using System;

namespace _07._Hotel_Room
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartamentPrice = 0;
            double studioDiscount = 0;
            double apartamentDiscount = 0;
            
            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartamentPrice = 65;

                if (days > 7 && days < 14)
                {
                    studioDiscount = studioPrice - ((studioPrice / 100) * 5) ;
                    studioPrice = studioDiscount * days;
                    apartamentPrice = apartamentPrice * days;

                }
                else if (days > 14)
                {
                    studioDiscount = studioPrice - ((studioPrice / 100) * 30);
                    studioPrice = studioDiscount * days;
                    apartamentDiscount = apartamentPrice - ((apartamentPrice / 100) * 10);
                    apartamentPrice = apartamentDiscount * days;
                }
                else
                {
                    studioPrice = studioPrice * days;
                    apartamentPrice = apartamentPrice * days;
                }
                
                

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartamentPrice = 68.70;

                if (days > 14)
                {
                    studioDiscount = studioPrice - ((studioPrice / 100) * 20);
                    studioPrice = studioDiscount * days;
                    apartamentDiscount = apartamentPrice - ((apartamentPrice / 100) * 10);
                    apartamentPrice = apartamentDiscount * days;
                }
                else
                {
                    studioPrice = studioPrice * days;
                    apartamentPrice = apartamentPrice * days;

                }

                
            }
            else if ( month == "July" || month == "August")
            {
                studioPrice = 76;
                apartamentPrice = 77;

                if (days > 14)
                {
                    apartamentDiscount = apartamentPrice - ((apartamentPrice / 100) * 10);
                    apartamentPrice = apartamentDiscount * days;
                    studioPrice = studioPrice * days;
                }
                else
                {
                    studioPrice = studioPrice * days;
                    apartamentPrice = apartamentPrice * days;
                }
                
            }

            Console.WriteLine($"Apartment: {apartamentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");


        }
    }
}
