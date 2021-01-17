using System;

namespace Programming_Basics_Online_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double veganMenu = double.Parse(Console.ReadLine());
            double totalChicken = chickenMenu * 10.35;
            double totalFish = fishMenu * 12.40;
            double totalVegan = veganMenu * 8.15;
            double totalMenu = totalChicken + totalFish + totalVegan;
            double dessert = totalMenu / 100 * 20;
            double sum = totalMenu + dessert + 2.50;
            
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
