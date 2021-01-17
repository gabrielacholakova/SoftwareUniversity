﻿using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            

            while (array.Length != 1)
            {
                int[] sum = new int[array.Length-1];

                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = array[i] + array[i + 1];
                }
                array = sum;
            }
            Console.WriteLine(String.Join(" ",array));
        }
    }
}