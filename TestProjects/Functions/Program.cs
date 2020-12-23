using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Basic functions
             * 1. Write a function that prints out whatever string you pass into it. Call the function to make sure it works.
             * 2. Write a function that concatenates three strings and returns the result. Call the function to make sure it works.
             * 3. Write a function that takes in an int array, an int index, and an int value. The function should update the array at the specified index with the specified value. If the index is out of range, the function should do nothing. Call the function to make sure it works.
             * 4. Write a function that takes in a string and returns a new string that contains every other word (starting from the first) in the original. Call the function to make sure it works.
                  * a. For example, passing in “to be or not to be” should return “to or to”
              * 5. Write a function that takes in a string, an optional int parameter called index, and an optional int parameter called length. The function should return a substring of the original string starting at the specified index, with the specified length. Call the function to make sure it works.
                  * a. If the index or length are out of range, the function should return an empty string.
                  * b. If the index is not specified, start at index 0
                  * c. If the length is not specified (or is 0), take the rest of the string
             */

            static void PrintString(string userInput)
            {
                Console.WriteLine(userInput);
            }

            PrintString("hi");
            PrintString("you");

            
            static string ConcatenateStrings(string a, string b, string c)
            {
                return a + b + c;
            }

            string concatenatedString = ConcatenateStrings("hey", "you", "how are you?");
            Console.WriteLine(concatenatedString);
        }
    }
}
