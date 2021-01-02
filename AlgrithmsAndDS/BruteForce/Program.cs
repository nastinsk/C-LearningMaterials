using System;

namespace BruteForce
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsFirstCharRepeated("abcdefg"));
            Console.WriteLine(IsFirstCharRepeated("lajkkjla"));

           
        }
        /*
             * Brute force (linear search)
             * 1. Write a function called IsFirstCharRepeated that takes in a string and returns a bool.
             * 2. The function should return true if the first character is repeated anywhere else in the string
             * 3. Write a unit test and test this function
             */
        public static bool IsFirstCharRepeated(string inputStr)
        {
            char firstChar = inputStr[0];
            for (var i = 1; i < inputStr.Length; i++)
            {
                if(inputStr[i] == firstChar)
                {
                    return true;
                }

                
            }
            return false;
        }
    }
}
