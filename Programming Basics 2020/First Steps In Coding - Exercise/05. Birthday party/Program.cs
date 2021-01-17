using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double hall = double.Parse(Console.ReadLine());

            double cake = (hall / 100) * 20;
            double drinks = cake - ((cake / 100) * 45);
            double animator = hall / 3;

            double sumNeeded = hall + cake + drinks + animator;

            Console.WriteLine(sumNeeded);
        }
    }
}
