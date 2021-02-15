using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();
            var queue = new Queue<char>(input);
            var stack = new Stack<char>(input);
           
            string pairOne = "{}";
            string pairTwo = "[]";
            string pairThree = "()";
            var flag = true;
            for (int i = 0; i < input.Length/2; i++)
            {
                 string first = queue.Dequeue().ToString();
                 string second = stack.Pop().ToString();
                string total = first + second;
               
                if (total == pairOne || total == pairTwo || total == pairThree)
                {
                    continue;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("NO");
                    break;
                }
            }
            if (flag )
            {
                Console.WriteLine("YES");
            }
            
        }
    }
}
