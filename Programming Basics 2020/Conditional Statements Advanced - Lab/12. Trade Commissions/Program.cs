using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0;

            if (city == "Sofia")
            {
                if (sales >=0 && sales <=500)
                {
                    commision = (sales / 100) * 5;
                }
                else if(sales > 500 && sales <= 1000)
                {
                    commision = (sales / 100) * 7;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = (sales / 100) * 8;
                }
                else if (sales > 10000)
                {
                    commision = (sales / 100) * 12;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = (sales / 100) * 4.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = (sales / 100) * 7.5;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = (sales / 100) * 10;
                }
                else if (sales > 10000)
                {
                    commision = (sales / 100) * 13;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (city =="Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = (sales / 100) * 5.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = (sales / 100) * 8;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = (sales / 100) * 12;
                }
                else if (sales > 10000)
                {
                    commision = (sales / 100) * 14.5;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }

            else
            {
                Console.WriteLine("error");
                return;
            }

            Console.WriteLine($"{commision:F2}");
        }
    }
}
