using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string products = Console.ReadLine();
                list.Add(products);

            }
            list.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
            
            
        }
    }
}
