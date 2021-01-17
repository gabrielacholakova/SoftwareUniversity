using System;
using System.Text.RegularExpressions;

namespace _04._Password_Validator
{
    public static class StringExtensions
    {
        public static string[] ToStringArray(this string password)
        {
            string[] arr = new string[password.Length];

            for (int i = 0; i < password.Length; i++)
            {
                arr[i] = password[i].ToString();
            }

            return arr;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();

            bool countOfCharacters = CountOfCharacters(password);
            bool lettersAndDigits = LettersAndDigits(password);
            bool countOfDigits = CountOfDigits(password);

            if (countOfCharacters == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (lettersAndDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (countOfDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (countOfCharacters && lettersAndDigits && countOfDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool CountOfCharacters(string password)
        {

            if (password.Length < 6 || password.Length > 10)
            {
                return false;
                //Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                return true;
            }

        }
        static bool CountOfDigits(string password)
        {
            int sum = 0;
            string[] arr = new string[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
                arr[i] = password[i].ToString();
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (arr[i] == "0" || arr[i] == "1" || arr[i] == "2" || arr[i] == "3" || arr[i] == "4" || arr[i] == "5" || arr[i] == "6" || arr[i] == "7" || arr[i] == "8" || arr[i] == "9")
                {
                    sum++;
                }
            }
            if (sum < 2)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        static bool LettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsDigit(symbol) && !char.IsLetter(symbol))
                {
                    return false;
                }

            }

                return true;
        }

    }
}
