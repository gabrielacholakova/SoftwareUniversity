using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lengh = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double result = 0;
            double cakeSize = 0;
            double cake = 0;


            while (true)
            {
                
               
                if (input == "STOP")
                {
                    if ( cakeSize > result)
                    {
                        double piecesLeft = cakeSize - result;
                        Console.WriteLine($"{result} pieces are left.");
                        break;
                    }
                    else if (result > cakeSize)
                    {
                        double morePieces = result - cakeSize;
                        Console.WriteLine($"No more cake left! You need {morePieces} pieces more.");
                        break;
                    }
                }
                double piecesTaken = double.Parse(input);

                cakeSize = width * lengh;
                cake += piecesTaken;
                
                result = cakeSize - cake;

                if (cakeSize <= cake)
                {
                    double piecesNeeded = cake - cakeSize;
                    Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
                    break;
                }

                input = Console.ReadLine();

            }

        }
    }
}
