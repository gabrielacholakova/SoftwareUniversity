using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int result = 0;
            int steps = 0;
            bool flag = false;

            for (int i = start; i <= end; i++)
            {
                for (int k =start; k <= end; k++)
                {
                    steps++;
                    result = i + k;

                  if (result == magicNum)
                  {
                     Console.WriteLine($"Combination N:{steps} ({i} + {k} = {magicNum})");
                     
                     flag = true;
                     break;
                  }
                      
                }
                if (flag)
                {
                    break;
                }
            }

            if (result != magicNum)
            {
                Console.WriteLine($"{steps} combinations - neither equals {magicNum}");
            }
           
            
        }
        
    }
}
