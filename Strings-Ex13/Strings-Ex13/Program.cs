using System;

namespace Strings_Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "This is a string";
            Console.WriteLine(AddSufix(givenString));
        }

        //Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends with 'ing' then add 'ly' instead.
        //If the string length of the given string is less than 3, leave it unchanged.
        public static string AddSufix(string input)
        {
            if (input.Length < 3)
            {
                return input;
            }

            string sufix1 = "ing";
            string sufix2 = "ly";

            if (input.LastIndexOf(sufix1, StringComparison.InvariantCulture) == -1)
            {
                input += sufix1;
            }
            else
            {
                input += sufix2;
            }

            return input;
        }
    }
}
