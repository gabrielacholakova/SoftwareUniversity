using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            string firstPattern = @"[SsTtAaRr]";
            string secondPattern = @"[^@\-!:>]*@(?<planet>[A-Za-z]+)[^@\-!:>]*:[^@\-!:>]*?(?<population>\d+)(?<attackType>[!AD!]+)[^@\-!:>]*?->[^@\-!:>]*?(?<soldierCount>\d+)[^@\-!:>]*?.*";
            int attack = 0;
            int destruction = 0;
            List<string> attackedPlanets = new List<string>();
            List<string> destructedPlanets = new List<string>();

            
            for (int i = 0; i < countOfLines; i++)
            {
                string decryptedMessage = string.Empty;
                string input = Console.ReadLine();
                var matches = Regex.Matches(input, firstPattern);
                int count = matches.Count; //3

                foreach (var character in input)
                {
                    decryptedMessage += (char)(character - count);
                }

                var secondMatches = Regex.Match(decryptedMessage, secondPattern);
                var planet = secondMatches.Groups["planet"].Value;
                var population = secondMatches.Groups["population"].Value;
                var attackType = secondMatches.Groups["attackType"].Value;
                if (attackType == "!A!")
                {
                    attack++;
                    attackedPlanets.Add(planet);
                }
                if(attackType == "!D!")
                {
                    destruction++;
                    destructedPlanets.Add(planet);
                }
                var soldiersCount = secondMatches.Groups["soldierCount"].Value;
            }

            Console.WriteLine($"Attacked planets: {attack}");
            attackedPlanets.Sort();
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            
            Console.WriteLine($"Destroyed planets: {destruction}");
            destructedPlanets.Sort();
            foreach (var planet in destructedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            

        }
    }
}
