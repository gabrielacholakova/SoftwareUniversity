using System;

namespace Methods___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstNum,secondNum,thirdNum));

        }
        static int SmallestNumber (int firstNum, int secondNum, int thirdNum)
        {
            int smallest = 0;

            if (firstNum <= secondNum && firstNum <= thirdNum)
            {
                smallest = firstNum;
            }
            else if (secondNum <= firstNum && secondNum <= thirdNum)
            {
                smallest = secondNum;
            }
            else if (thirdNum <= firstNum && thirdNum <= secondNum)
            {
                smallest = thirdNum;
            }
            
            return smallest;
        }
    }
}
