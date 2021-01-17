using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] array = new int[numbers.Length];

            if (rotations == 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int k = 0; k < rotations; k++)
                {

                    for (int i = 0; i < numbers.Length; i++)
                    {

                        if (i == numbers.Length - 1)
                        {
                            array[i] = numbers[0];
                            numbers = array.ToArray();
                        }
                        else
                        {
                            array[i] = numbers[i + 1];
                        }
                    }


                }
                Console.WriteLine(string.Join(" ", array));
            }



        }
    }
}
