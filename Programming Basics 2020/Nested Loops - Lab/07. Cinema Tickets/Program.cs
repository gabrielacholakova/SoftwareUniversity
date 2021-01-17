using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double standard = 0;
            double student = 0;
            double kids = 0;
            double tickets = 0;
            double totalTickets = 0;
            double totalStandardTickets = 0;
            double totalStudentTickets = 0;
            double totalKidsTickets = 0;
            double full = 0;
            double standardPercent = 0;
            double studentPercent = 0;
            double kidsPercent = 0;
            
            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    totalStandardTickets = standardPercent / totalTickets * 100;
                    totalStudentTickets = studentPercent / totalTickets * 100;
                    totalKidsTickets = kidsPercent / totalTickets * 100;

                    Console.WriteLine($"Total tickets: {totalTickets}");
                    Console.WriteLine($"{totalStudentTickets:F2}% student tickets.");
                    Console.WriteLine($"{totalStandardTickets:F2}% standard tickets.");
                    Console.WriteLine($"{totalKidsTickets:F2}% kids tickets.");
                    
                    break;
                }
                double capacity = double.Parse(Console.ReadLine());

                while (true)
                {
                    string typeOfTickets = Console.ReadLine();
                    if (typeOfTickets == "End" )
                    {
                        
                        totalTickets += tickets;
                        full = tickets / capacity * 100;
                       
                        tickets = 0;
                        standard = 0;
                        student = 0;
                        kids = 0;
                        Console.WriteLine($"{movie} - {full:F2}% full.");
                       
                        break;
                        
                    }
                    switch (typeOfTickets)
                    {
                        case "standard":
                            standard += 1;
                            standardPercent += 1;
                            break;
                        case "student":
                            student += 1;
                            studentPercent += 1;
                            break;
                        case "kid":
                            kids += 1;
                            kidsPercent += 1;
                            break;
                    }
                   tickets = standard + kids + student;
                    if (tickets == capacity)
                    {
                        totalTickets += tickets;
                        full = tickets / capacity * 100;
                        tickets = 0;
                        standard = 0;
                        student = 0;
                        kids = 0;
                        Console.WriteLine($"{movie} - {full:F2}% full.");
                        break;
                      
                    }

                }
               
            }
        }
    }
}
