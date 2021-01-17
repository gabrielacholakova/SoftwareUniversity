using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(numberTwo, numberTwo));
            }
            else if (type == "string")
            {
                string numberOne = Console.ReadLine();
                string numberTwo = Console.ReadLine();
                Console.WriteLine(GetMax(numberTwo, numberTwo));
            }
            else if (type == "char")
            {
                char numberOne = char.Parse(Console.ReadLine());
                char numberTwo = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(numberTwo, numberTwo));
            }


        }

        static int GetMax(int numberOne, int numberTwo)
        {
            int result = numberOne.CompareTo(numberTwo);

            if (result > 0)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }

        }
        static string GetMax(string numberOne, string numberTwo)
        {
            int result = numberOne.CompareTo(numberTwo);

            if (result > 0)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }

        }
        static char GetMax(char numberOne, char numberTwo)
        {
            int result = numberOne.CompareTo(numberTwo);

            if (result > 0)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }

        }
    }
}
