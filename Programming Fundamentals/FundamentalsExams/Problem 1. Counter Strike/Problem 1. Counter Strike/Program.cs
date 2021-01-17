using System;

namespace Problem_1._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialEnergy = Console.ReadLine();
            int energyLeft = 0;
            int counter = 0;
            int wonBattles = 0;
            int energy = (int.Parse)(initialEnergy);
            while (true)
            {
                initialEnergy = Console.ReadLine();
                if (initialEnergy == "End of battle")
                {
                    Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
                    break;
                }

                int distance = int.Parse(initialEnergy);

               
               energy = energy -  distance;
                counter++;
                wonBattles++;
                if (counter == 3 )
                {
                    energy += wonBattles;
                    counter = 0;
                }
                if (energy < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles - 1} won battles and 0 energy");
                    break;
                }
                

            }
        }
    }
}
