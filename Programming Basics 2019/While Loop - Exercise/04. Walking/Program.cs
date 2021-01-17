using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = 0;
            int moreSteps = 0;
            
            while (true)
            {
                if (input == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    result += lastSteps;
                    
                    if (result >= 10000)
                    {
                        moreSteps = result - 10000;
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{moreSteps} steps over the goal!");
                        break;
                    }
                    if (result < 10000)
                    {
                        moreSteps = 10000 - result;
                        Console.WriteLine($"{moreSteps} more steps to reach goal.");
                        break;
                    }
                }
                int steps = int.Parse(input);
                
                    result += steps;

                if(result >= 10000)
                {
                    moreSteps = result - 10000;
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{moreSteps} steps over the goal!");
                    break;
                }
               
                
                input = Console.ReadLine();
            }
        }
    }
}
