using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(" : ").ToList();
                
                if (input[0] == "end")
                {
                    break;
                }
                string program = input[0];
                string student = input[1];
                if (!dict.ContainsKey(program)) 
                {
                    dict.Add(program, new List<string>());
                    dict[program].Add(student);
                }
                else
                {
                    dict[program].Add(student);
                }
            }
            int result = dict.Count;
            
            foreach (var pair in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine(pair.Key +": " + pair.Value.Count);
                List<string> course = pair.Value;
                course.Sort();
                foreach (var persons in course)
                {
                    Console.WriteLine("-- " + persons);
                }
                
            }
        }
    }
}
